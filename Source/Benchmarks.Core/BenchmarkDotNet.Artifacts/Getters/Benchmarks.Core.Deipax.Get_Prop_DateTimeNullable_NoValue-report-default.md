
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XPIDXK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-TONOSH : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-YEBKOB : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-TGKQNS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PNUVLP : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  0.9418 ns | 0.0038 ns | 0.0033 ns |  0.9422 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.1056 ns | 0.0026 ns | 0.0024 ns |  1.1057 ns |  1.17 |    0.01 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.1783 ns | 0.0025 ns | 0.0023 ns |  1.1782 ns |  1.25 |    0.01 |     - |     - |     - |         - |
             ToBool |        net461 |  0.7312 ns | 0.0061 ns | 0.0051 ns |  0.7325 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 |  0.4762 ns | 0.0023 ns | 0.0022 ns |  0.4761 ns |  0.51 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  9.4992 ns | 0.0109 ns | 0.0101 ns |  9.5015 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 | 10.2713 ns | 0.0355 ns | 0.0297 ns | 10.2785 ns |  1.08 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.9323 ns | 0.0064 ns | 0.0060 ns |  4.9336 ns |  0.52 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 | 10.2435 ns | 0.0438 ns | 0.0388 ns | 10.2523 ns |  1.08 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 | 10.1636 ns | 0.0165 ns | 0.0154 ns | 10.1569 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.4518 ns | 0.0044 ns | 0.0041 ns |  1.4514 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.1903 ns | 0.0032 ns | 0.0029 ns |  1.1904 ns |  0.82 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.3764 ns | 0.0020 ns | 0.0019 ns |  1.3766 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             ToChar |        net461 |  0.9481 ns | 0.0022 ns | 0.0020 ns |  0.9479 ns |  0.65 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  0.6535 ns | 0.0025 ns | 0.0022 ns |  0.6535 ns |  0.45 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  9.6064 ns | 0.0113 ns | 0.0106 ns |  9.6050 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 | 10.1763 ns | 0.0115 ns | 0.0107 ns | 10.1774 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.7007 ns | 0.0069 ns | 0.0054 ns |  4.7009 ns |  0.49 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 | 10.1642 ns | 0.0108 ns | 0.0101 ns | 10.1649 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 | 10.1608 ns | 0.0103 ns | 0.0096 ns | 10.1632 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  0.9448 ns | 0.0029 ns | 0.0026 ns |  0.9446 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.1096 ns | 0.0029 ns | 0.0028 ns |  1.1098 ns |  1.17 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.4156 ns | 0.0034 ns | 0.0032 ns |  1.4159 ns |  1.50 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net461 |  0.7060 ns | 0.0022 ns | 0.0020 ns |  0.7060 ns |  0.75 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net472 |  0.5347 ns | 0.0026 ns | 0.0023 ns |  0.5354 ns |  0.57 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  9.8237 ns | 0.0114 ns | 0.0107 ns |  9.8246 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 | 10.1640 ns | 0.0111 ns | 0.0104 ns | 10.1639 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.7025 ns | 0.0027 ns | 0.0024 ns |  4.7024 ns |  0.48 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 | 10.1830 ns | 0.0161 ns | 0.0151 ns | 10.1795 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 | 10.1637 ns | 0.0122 ns | 0.0108 ns | 10.1666 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.0802 ns | 0.0026 ns | 0.0024 ns |  1.0800 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.6587 ns | 0.0115 ns | 0.0108 ns |  1.6627 ns |  1.54 |    0.01 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.4003 ns | 0.0022 ns | 0.0018 ns |  1.3998 ns |  1.30 |    0.00 |     - |     - |     - |         - |
             ToByte |        net461 |  0.9234 ns | 0.0017 ns | 0.0015 ns |  0.9232 ns |  0.85 |    0.00 |     - |     - |     - |         - |
             ToByte |        net472 |  0.6622 ns | 0.0031 ns | 0.0029 ns |  0.6620 ns |  0.61 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  9.7324 ns | 0.0096 ns | 0.0080 ns |  9.7312 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 | 10.1715 ns | 0.0109 ns | 0.0102 ns | 10.1711 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.7082 ns | 0.0251 ns | 0.0222 ns |  4.6975 ns |  0.48 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 | 10.1755 ns | 0.0161 ns | 0.0151 ns | 10.1790 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 | 10.2504 ns | 0.0082 ns | 0.0077 ns | 10.2474 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  0.9423 ns | 0.0023 ns | 0.0020 ns |  0.9423 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.1043 ns | 0.0038 ns | 0.0033 ns |  1.1033 ns |  1.17 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.1794 ns | 0.0024 ns | 0.0022 ns |  1.1793 ns |  1.25 |    0.00 |     - |     - |     - |         - |
            ToShort |        net461 |  0.7179 ns | 0.0024 ns | 0.0022 ns |  0.7178 ns |  0.76 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 |  0.4767 ns | 0.0021 ns | 0.0020 ns |  0.4760 ns |  0.51 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  9.7445 ns | 0.0139 ns | 0.0123 ns |  9.7408 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 | 10.1682 ns | 0.0079 ns | 0.0074 ns | 10.1697 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.7416 ns | 0.0216 ns | 0.0181 ns |  4.7474 ns |  0.49 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 | 10.1579 ns | 0.0129 ns | 0.0121 ns | 10.1610 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 | 10.1669 ns | 0.0136 ns | 0.0127 ns | 10.1704 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.0982 ns | 0.0036 ns | 0.0033 ns |  1.0972 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.1884 ns | 0.0022 ns | 0.0020 ns |  1.1879 ns |  1.08 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.1834 ns | 0.0054 ns | 0.0051 ns |  1.1836 ns |  1.08 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net461 |  0.9503 ns | 0.0039 ns | 0.0037 ns |  0.9490 ns |  0.87 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 |  0.6615 ns | 0.0018 ns | 0.0016 ns |  0.6614 ns |  0.60 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 | 10.9011 ns | 0.0635 ns | 0.0594 ns | 10.8633 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 | 10.1679 ns | 0.0103 ns | 0.0097 ns | 10.1654 ns |  0.93 |    0.01 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.9308 ns | 0.1027 ns | 0.0960 ns |  4.9782 ns |  0.45 |    0.01 |     - |     - |     - |         - |
   ToUShortNullable |        net461 | 10.1613 ns | 0.0078 ns | 0.0073 ns | 10.1628 ns |  0.93 |    0.01 |     - |     - |     - |         - |
   ToUShortNullable |        net472 | 11.7765 ns | 0.0100 ns | 0.0094 ns | 11.7780 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  0.9450 ns | 0.0040 ns | 0.0033 ns |  0.9453 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  2.3254 ns | 0.0037 ns | 0.0031 ns |  2.3251 ns |  2.46 |    0.01 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.4055 ns | 0.0115 ns | 0.0108 ns |  1.4004 ns |  1.49 |    0.01 |     - |     - |     - |         - |
              ToInt |        net461 |  0.7033 ns | 0.0030 ns | 0.0028 ns |  0.7045 ns |  0.74 |    0.00 |     - |     - |     - |         - |
              ToInt |        net472 |  0.5334 ns | 0.0033 ns | 0.0031 ns |  0.5334 ns |  0.56 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  9.8089 ns | 0.0205 ns | 0.0191 ns |  9.8140 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 | 10.1802 ns | 0.0288 ns | 0.0270 ns | 10.1689 ns |  1.04 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.7119 ns | 0.0085 ns | 0.0075 ns |  4.7098 ns |  0.48 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 | 10.1626 ns | 0.0172 ns | 0.0153 ns | 10.1576 ns |  1.04 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 | 10.1538 ns | 0.0192 ns | 0.0170 ns | 10.1557 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.1690 ns | 0.0022 ns | 0.0021 ns |  1.1688 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.2090 ns | 0.0032 ns | 0.0029 ns |  1.2092 ns |  1.03 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.4030 ns | 0.0027 ns | 0.0025 ns |  1.4032 ns |  1.20 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net461 |  0.9316 ns | 0.0033 ns | 0.0031 ns |  0.9310 ns |  0.80 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net472 |  0.6623 ns | 0.0029 ns | 0.0027 ns |  0.6625 ns |  0.57 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  9.7751 ns | 0.0468 ns | 0.0438 ns |  9.7542 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 | 10.2687 ns | 0.0345 ns | 0.0323 ns | 10.2761 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.7013 ns | 0.0044 ns | 0.0039 ns |  4.7019 ns |  0.48 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 | 10.1938 ns | 0.0132 ns | 0.0123 ns | 10.1926 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 | 10.2483 ns | 0.0278 ns | 0.0260 ns | 10.2536 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  0.9725 ns | 0.0026 ns | 0.0025 ns |  0.9722 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.1053 ns | 0.0031 ns | 0.0029 ns |  1.1047 ns |  1.14 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.1904 ns | 0.0077 ns | 0.0068 ns |  1.1912 ns |  1.22 |    0.01 |     - |     - |     - |         - |
             ToLong |        net461 |  0.7161 ns | 0.0020 ns | 0.0018 ns |  0.7161 ns |  0.74 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 |  0.4759 ns | 0.0024 ns | 0.0023 ns |  0.4761 ns |  0.49 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.8386 ns | 0.0019 ns | 0.0017 ns |  1.8385 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.6521 ns | 0.0057 ns | 0.0053 ns |  1.6512 ns |  0.90 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.7036 ns | 0.0034 ns | 0.0030 ns |  1.7032 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  1.6762 ns | 0.0032 ns | 0.0027 ns |  1.6765 ns |  0.91 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  1.6518 ns | 0.0020 ns | 0.0019 ns |  1.6516 ns |  0.90 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.1740 ns | 0.0046 ns | 0.0043 ns |  1.1746 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.1030 ns | 0.0025 ns | 0.0023 ns |  1.1028 ns |  0.94 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.1810 ns | 0.0023 ns | 0.0021 ns |  1.1814 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            ToULong |        net461 |  0.7228 ns | 0.0040 ns | 0.0037 ns |  0.7222 ns |  0.62 |    0.00 |     - |     - |     - |         - |
            ToULong |        net472 |  0.4768 ns | 0.0024 ns | 0.0021 ns |  0.4767 ns |  0.41 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.7547 ns | 0.0210 ns | 0.0197 ns |  1.7591 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.6506 ns | 0.0026 ns | 0.0024 ns |  1.6507 ns |  0.94 |    0.01 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.7028 ns | 0.0030 ns | 0.0023 ns |  1.7027 ns |  0.97 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  1.7721 ns | 0.0068 ns | 0.0060 ns |  1.7707 ns |  1.01 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  1.6490 ns | 0.0041 ns | 0.0038 ns |  1.6486 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.2024 ns | 0.0152 ns | 0.0142 ns |  1.2072 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.4030 ns | 0.0018 ns | 0.0017 ns |  1.4026 ns |  1.17 |    0.01 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.1822 ns | 0.0026 ns | 0.0022 ns |  1.1821 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net461 |  0.9242 ns | 0.0044 ns | 0.0037 ns |  0.9237 ns |  0.77 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.9617 ns | 0.0044 ns | 0.0037 ns |  1.9611 ns |  1.63 |    0.02 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  9.9777 ns | 0.0127 ns | 0.0119 ns |  9.9744 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 | 10.1714 ns | 0.0058 ns | 0.0052 ns | 10.1712 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.7429 ns | 0.0291 ns | 0.0227 ns |  4.7510 ns |  0.48 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 | 11.9204 ns | 0.0429 ns | 0.0381 ns | 11.9160 ns |  1.19 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net472 | 10.2628 ns | 0.0444 ns | 0.0394 ns | 10.2762 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.1942 ns | 0.0126 ns | 0.0118 ns |  1.1883 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.2220 ns | 0.0053 ns | 0.0049 ns |  1.2209 ns |  1.02 |    0.01 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.3232 ns | 0.0022 ns | 0.0020 ns |  1.3240 ns |  1.11 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net461 |  0.7356 ns | 0.0170 ns | 0.0159 ns |  0.7330 ns |  0.62 |    0.02 |     - |     - |     - |         - |
           ToDouble |        net472 |  0.5067 ns | 0.0057 ns | 0.0051 ns |  0.5061 ns |  0.42 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.7800 ns | 0.0037 ns | 0.0035 ns |  1.7792 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.6505 ns | 0.0025 ns | 0.0023 ns |  1.6502 ns |  0.93 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.7786 ns | 0.0032 ns | 0.0027 ns |  1.7778 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.7402 ns | 0.0043 ns | 0.0040 ns |  1.7396 ns |  0.98 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.6488 ns | 0.0039 ns | 0.0036 ns |  1.6490 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  8.9338 ns | 0.0227 ns | 0.0201 ns |  8.9334 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  8.6018 ns | 0.0117 ns | 0.0104 ns |  8.6002 ns |  0.96 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.8223 ns | 0.0034 ns | 0.0030 ns |  2.8227 ns |  0.32 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net461 | 16.5019 ns | 0.1000 ns | 0.0936 ns | 16.4521 ns |  1.85 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net472 | 11.1002 ns | 0.0137 ns | 0.0121 ns | 11.0992 ns |  1.24 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  1.6898 ns | 0.0080 ns | 0.0075 ns |  1.6917 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  1.8386 ns | 0.0042 ns | 0.0040 ns |  1.8382 ns |  1.09 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  1.9224 ns | 0.0033 ns | 0.0031 ns |  1.9219 ns |  1.14 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 |  2.0589 ns | 0.0102 ns | 0.0096 ns |  2.0602 ns |  1.22 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 |  1.8924 ns | 0.0113 ns | 0.0106 ns |  1.8952 ns |  1.12 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3494 ns | 0.0028 ns | 0.0026 ns |  2.3492 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.7803 ns | 0.0033 ns | 0.0028 ns |  2.7808 ns |  1.18 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.7816 ns | 0.0057 ns | 0.0047 ns |  2.7815 ns |  1.18 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.6435 ns | 0.0020 ns | 0.0017 ns |  1.6440 ns |  0.70 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.6338 ns | 0.0033 ns | 0.0031 ns |  1.6329 ns |  0.70 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  1.8509 ns | 0.0030 ns | 0.0027 ns |  1.8516 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  1.8741 ns | 0.0025 ns | 0.0024 ns |  1.8732 ns |  1.01 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9054 ns | 0.0020 ns | 0.0016 ns |  1.9052 ns |  1.03 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  1.6704 ns | 0.0044 ns | 0.0041 ns |  1.6696 ns |  0.90 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  1.6241 ns | 0.0031 ns | 0.0024 ns |  1.6235 ns |  0.88 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.2507 ns | 0.0083 ns | 0.0078 ns |  1.2519 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.4140 ns | 0.0032 ns | 0.0030 ns |  1.4134 ns |  1.13 |    0.01 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.6317 ns | 0.0025 ns | 0.0023 ns |  1.6321 ns |  1.30 |    0.01 |     - |     - |     - |         - |
           ToObject |        net461 |  0.9791 ns | 0.0028 ns | 0.0023 ns |  0.9786 ns |  0.78 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  0.9464 ns | 0.0019 ns | 0.0017 ns |  0.9466 ns |  0.76 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.4007 ns | 0.0100 ns | 0.0094 ns |  1.3972 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.5283 ns | 0.0091 ns | 0.0085 ns |  1.5288 ns |  1.09 |    0.01 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.6454 ns | 0.0027 ns | 0.0024 ns |  1.6451 ns |  1.17 |    0.01 |     - |     - |     - |         - |
          To_String |        net461 |  1.4905 ns | 0.0062 ns | 0.0058 ns |  1.4917 ns |  1.06 |    0.01 |     - |     - |     - |         - |
          To_String |        net472 |  1.4317 ns | 0.0026 ns | 0.0023 ns |  1.4320 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.4037 ns | 0.0028 ns | 0.0026 ns |  1.4042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.5333 ns | 0.0029 ns | 0.0025 ns |  1.5333 ns |  1.09 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.6327 ns | 0.0023 ns | 0.0019 ns |  1.6325 ns |  1.16 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.4597 ns | 0.0030 ns | 0.0028 ns |  1.4594 ns |  1.04 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.4272 ns | 0.0024 ns | 0.0021 ns |  1.4275 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  9.7384 ns | 0.0135 ns | 0.0127 ns |  9.7365 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 10.2675 ns | 0.0207 ns | 0.0184 ns | 10.2679 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  4.7031 ns | 0.0072 ns | 0.0067 ns |  4.7038 ns |  0.48 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  9.9786 ns | 0.0138 ns | 0.0129 ns |  9.9778 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  9.9329 ns | 0.0104 ns | 0.0097 ns |  9.9310 ns |  1.02 |    0.00 |     - |     - |     - |         - |
