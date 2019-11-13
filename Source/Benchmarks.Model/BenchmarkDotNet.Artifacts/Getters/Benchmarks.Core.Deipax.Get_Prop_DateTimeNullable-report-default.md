
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
             ToBool | .NET Core 2.0 |   0.9476 ns | 0.0073 ns | 0.0065 ns |   0.9456 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |   1.1542 ns | 0.0028 ns | 0.0026 ns |   1.1540 ns |  1.22 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |   1.3358 ns | 0.0026 ns | 0.0023 ns |   1.3356 ns |  1.41 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |   0.7195 ns | 0.0018 ns | 0.0017 ns |   0.7191 ns |  0.76 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |   0.4754 ns | 0.0016 ns | 0.0013 ns |   0.4757 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |   9.5245 ns | 0.0104 ns | 0.0087 ns |   9.5235 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  10.1965 ns | 0.0322 ns | 0.0301 ns |  10.1787 ns |  1.07 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |   4.7762 ns | 0.1137 ns | 0.1117 ns |   4.7062 ns |  0.50 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  10.1658 ns | 0.0102 ns | 0.0095 ns |  10.1664 ns |  1.07 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  10.1663 ns | 0.0103 ns | 0.0091 ns |  10.1649 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |   1.1044 ns | 0.0031 ns | 0.0029 ns |   1.1036 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |   1.4095 ns | 0.0045 ns | 0.0040 ns |   1.4100 ns |  1.28 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |   1.1852 ns | 0.0022 ns | 0.0021 ns |   1.1851 ns |  1.07 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |   0.9590 ns | 0.0097 ns | 0.0091 ns |   0.9607 ns |  0.87 |    0.01 |      - |     - |     - |         - |
             ToChar |        net472 |   0.6542 ns | 0.0021 ns | 0.0019 ns |   0.6541 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |   9.5239 ns | 0.0128 ns | 0.0114 ns |   9.5258 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  10.1707 ns | 0.0126 ns | 0.0111 ns |  10.1732 ns |  1.07 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |   4.7009 ns | 0.0239 ns | 0.0224 ns |   4.6980 ns |  0.49 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  10.1663 ns | 0.0101 ns | 0.0095 ns |  10.1673 ns |  1.07 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  10.1620 ns | 0.0139 ns | 0.0123 ns |  10.1603 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |   0.9474 ns | 0.0018 ns | 0.0016 ns |   0.9475 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |   1.1615 ns | 0.0046 ns | 0.0043 ns |   1.1624 ns |  1.23 |    0.01 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |   1.4042 ns | 0.0029 ns | 0.0025 ns |   1.4045 ns |  1.48 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |   0.7052 ns | 0.0019 ns | 0.0017 ns |   0.7056 ns |  0.74 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |   0.5335 ns | 0.0035 ns | 0.0033 ns |   0.5322 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |   9.7554 ns | 0.0117 ns | 0.0104 ns |   9.7547 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  10.1831 ns | 0.0078 ns | 0.0073 ns |  10.1819 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |   4.7403 ns | 0.0253 ns | 0.0237 ns |   4.7512 ns |  0.49 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  10.1709 ns | 0.0127 ns | 0.0119 ns |  10.1711 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  10.1681 ns | 0.0142 ns | 0.0133 ns |  10.1635 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |   1.0929 ns | 0.0128 ns | 0.0120 ns |   1.0871 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |   1.3738 ns | 0.0024 ns | 0.0022 ns |   1.3728 ns |  1.26 |    0.02 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |   1.1732 ns | 0.0023 ns | 0.0022 ns |   1.1731 ns |  1.07 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 |   0.9283 ns | 0.0035 ns | 0.0031 ns |   0.9287 ns |  0.85 |    0.01 |      - |     - |     - |         - |
             ToByte |        net472 |   0.6808 ns | 0.0066 ns | 0.0058 ns |   0.6810 ns |  0.62 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |   9.9850 ns | 0.0090 ns | 0.0084 ns |   9.9865 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  10.1366 ns | 0.0074 ns | 0.0062 ns |  10.1377 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |   4.6533 ns | 0.0068 ns | 0.0064 ns |   4.6527 ns |  0.47 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  10.2411 ns | 0.0763 ns | 0.0714 ns |  10.2698 ns |  1.03 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  10.1659 ns | 0.0155 ns | 0.0121 ns |  10.1652 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |   0.9447 ns | 0.0023 ns | 0.0022 ns |   0.9442 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |   1.1733 ns | 0.0164 ns | 0.0153 ns |   1.1833 ns |  1.24 |    0.02 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |   1.0566 ns | 0.0027 ns | 0.0024 ns |   1.0569 ns |  1.12 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |   0.7197 ns | 0.0020 ns | 0.0018 ns |   0.7200 ns |  0.76 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |   0.6912 ns | 0.0036 ns | 0.0034 ns |   0.6910 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |   9.5497 ns | 0.0099 ns | 0.0088 ns |   9.5479 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  10.1506 ns | 0.0114 ns | 0.0107 ns |  10.1491 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |   4.8960 ns | 0.0066 ns | 0.0059 ns |   4.8951 ns |  0.51 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  10.2340 ns | 0.0507 ns | 0.0396 ns |  10.2519 ns |  1.07 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  10.1551 ns | 0.0084 ns | 0.0078 ns |  10.1561 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |   1.1022 ns | 0.0039 ns | 0.0032 ns |   1.1013 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |   1.8652 ns | 0.0033 ns | 0.0029 ns |   1.8654 ns |  1.69 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |   1.2110 ns | 0.0139 ns | 0.0130 ns |   1.2146 ns |  1.10 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |   0.9438 ns | 0.0027 ns | 0.0023 ns |   0.9438 ns |  0.86 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |   0.6532 ns | 0.0027 ns | 0.0024 ns |   0.6534 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |   9.5390 ns | 0.0449 ns | 0.0420 ns |   9.5196 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  10.1594 ns | 0.0084 ns | 0.0075 ns |  10.1590 ns |  1.06 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |   4.6531 ns | 0.0064 ns | 0.0060 ns |   4.6517 ns |  0.49 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  10.1533 ns | 0.0097 ns | 0.0091 ns |  10.1513 ns |  1.06 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  10.2595 ns | 0.0097 ns | 0.0091 ns |  10.2592 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |   0.9460 ns | 0.0017 ns | 0.0015 ns |   0.9462 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |   1.1517 ns | 0.0034 ns | 0.0032 ns |   1.1516 ns |  1.22 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |   1.2692 ns | 0.0021 ns | 0.0017 ns |   1.2691 ns |  1.34 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |   0.7047 ns | 0.0016 ns | 0.0015 ns |   0.7047 ns |  0.74 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |   0.5347 ns | 0.0050 ns | 0.0044 ns |   0.5332 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |   9.7596 ns | 0.0445 ns | 0.0417 ns |   9.7354 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  10.1895 ns | 0.0587 ns | 0.0549 ns |  10.1607 ns |  1.04 |    0.01 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |   4.7043 ns | 0.0069 ns | 0.0054 ns |   4.7034 ns |  0.48 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  10.1613 ns | 0.0077 ns | 0.0064 ns |  10.1612 ns |  1.04 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  10.1934 ns | 0.0107 ns | 0.0095 ns |  10.1947 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |   1.1797 ns | 0.0038 ns | 0.0036 ns |   1.1796 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |   1.3734 ns | 0.0016 ns | 0.0013 ns |   1.3733 ns |  1.16 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |   1.2813 ns | 0.0046 ns | 0.0041 ns |   1.2804 ns |  1.09 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |   1.2237 ns | 0.0070 ns | 0.0062 ns |   1.2255 ns |  1.04 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |   0.6591 ns | 0.0036 ns | 0.0031 ns |   0.6590 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |   9.7543 ns | 0.0127 ns | 0.0106 ns |   9.7548 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  10.1412 ns | 0.0139 ns | 0.0130 ns |  10.1428 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |   4.7326 ns | 0.0244 ns | 0.0229 ns |   4.7424 ns |  0.48 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  10.1706 ns | 0.0148 ns | 0.0138 ns |  10.1720 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  10.1945 ns | 0.0199 ns | 0.0186 ns |  10.1885 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |   0.9918 ns | 0.0037 ns | 0.0035 ns |   0.9918 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |   1.1494 ns | 0.0023 ns | 0.0022 ns |   1.1495 ns |  1.16 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |   1.2032 ns | 0.0024 ns | 0.0021 ns |   1.2024 ns |  1.21 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |   0.7150 ns | 0.0030 ns | 0.0028 ns |   0.7148 ns |  0.72 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |   1.1880 ns | 0.0031 ns | 0.0029 ns |   1.1881 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |   1.8419 ns | 0.0028 ns | 0.0025 ns |   1.8420 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |   1.6386 ns | 0.0041 ns | 0.0034 ns |   1.6390 ns |  0.89 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |   1.6797 ns | 0.0211 ns | 0.0198 ns |   1.6870 ns |  0.91 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net461 |   1.6716 ns | 0.0022 ns | 0.0021 ns |   1.6718 ns |  0.91 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |   1.6544 ns | 0.0027 ns | 0.0026 ns |   1.6545 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |   1.1567 ns | 0.0045 ns | 0.0038 ns |   1.1567 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |   1.1473 ns | 0.0020 ns | 0.0019 ns |   1.1476 ns |  0.99 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |   1.4759 ns | 0.0557 ns | 0.0572 ns |   1.4783 ns |  1.28 |    0.06 |      - |     - |     - |         - |
            ToULong |        net461 |   0.7193 ns | 0.0023 ns | 0.0021 ns |   0.7189 ns |  0.62 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |   0.4788 ns | 0.0023 ns | 0.0021 ns |   0.4789 ns |  0.41 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |   1.7379 ns | 0.0031 ns | 0.0029 ns |   1.7386 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |   1.8209 ns | 0.0047 ns | 0.0044 ns |   1.8221 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |   1.8430 ns | 0.0036 ns | 0.0034 ns |   1.8438 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |   1.7722 ns | 0.0128 ns | 0.0119 ns |   1.7778 ns |  1.02 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |   1.6528 ns | 0.0021 ns | 0.0019 ns |   1.6532 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |   1.1896 ns | 0.0037 ns | 0.0033 ns |   1.1885 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |   1.3711 ns | 0.0146 ns | 0.0136 ns |   1.3764 ns |  1.15 |    0.01 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |   1.3195 ns | 0.0035 ns | 0.0032 ns |   1.3204 ns |  1.11 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |   0.9232 ns | 0.0033 ns | 0.0031 ns |   0.9220 ns |  0.78 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |   0.6757 ns | 0.0045 ns | 0.0042 ns |   0.6756 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  10.5997 ns | 0.0226 ns | 0.0211 ns |  10.6053 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  10.1612 ns | 0.0118 ns | 0.0110 ns |  10.1644 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |   4.7025 ns | 0.0101 ns | 0.0079 ns |   4.7009 ns |  0.44 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  10.1641 ns | 0.0104 ns | 0.0097 ns |  10.1616 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  10.1924 ns | 0.0092 ns | 0.0086 ns |  10.1902 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |   1.1898 ns | 0.0027 ns | 0.0025 ns |   1.1898 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |   1.5435 ns | 0.0575 ns | 0.1345 ns |   1.5512 ns |  1.33 |    0.10 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |   1.2612 ns | 0.0111 ns | 0.0104 ns |   1.2571 ns |  1.06 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |   0.7057 ns | 0.0021 ns | 0.0018 ns |   0.7056 ns |  0.59 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |   0.5136 ns | 0.0024 ns | 0.0021 ns |   0.5137 ns |  0.43 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |   1.8006 ns | 0.0201 ns | 0.0188 ns |   1.8065 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |   1.8163 ns | 0.0027 ns | 0.0025 ns |   1.8152 ns |  1.01 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |   1.6629 ns | 0.0035 ns | 0.0033 ns |   1.6629 ns |  0.92 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |   1.7371 ns | 0.0039 ns | 0.0036 ns |   1.7367 ns |  0.96 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |   1.6548 ns | 0.0037 ns | 0.0031 ns |   1.6547 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |   8.9509 ns | 0.0096 ns | 0.0090 ns |   8.9491 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |   8.7277 ns | 0.0168 ns | 0.0157 ns |   8.7262 ns |  0.98 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |   2.8391 ns | 0.0042 ns | 0.0040 ns |   2.8407 ns |  0.32 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  11.1879 ns | 0.0479 ns | 0.0448 ns |  11.2013 ns |  1.25 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net472 |  11.3700 ns | 0.0121 ns | 0.0113 ns |  11.3690 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |   1.6642 ns | 0.0149 ns | 0.0139 ns |   1.6572 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |   1.9860 ns | 0.0034 ns | 0.0028 ns |   1.9859 ns |  1.19 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |   1.8485 ns | 0.0101 ns | 0.0095 ns |   1.8511 ns |  1.11 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |   2.0239 ns | 0.0015 ns | 0.0011 ns |   2.0239 ns |  1.21 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |   1.8617 ns | 0.0020 ns | 0.0018 ns |   1.8615 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |   1.4483 ns | 0.0020 ns | 0.0018 ns |   1.4475 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |   1.7428 ns | 0.0034 ns | 0.0030 ns |   1.7438 ns |  1.20 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |   1.7119 ns | 0.0027 ns | 0.0025 ns |   1.7124 ns |  1.18 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |   1.9166 ns | 0.0035 ns | 0.0031 ns |   1.9175 ns |  1.32 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |   1.8879 ns | 0.0043 ns | 0.0040 ns |   1.8879 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |   1.8527 ns | 0.0029 ns | 0.0026 ns |   1.8525 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |   1.5998 ns | 0.0028 ns | 0.0024 ns |   1.5999 ns |  0.86 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |   1.6140 ns | 0.0125 ns | 0.0117 ns |   1.6090 ns |  0.87 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |   2.1077 ns | 0.0691 ns | 0.1281 ns |   2.0978 ns |  1.17 |    0.09 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |   1.6234 ns | 0.0023 ns | 0.0020 ns |   1.6228 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |   3.8240 ns | 0.0088 ns | 0.0082 ns |   3.8229 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |   4.5376 ns | 0.0080 ns | 0.0071 ns |   4.5377 ns |  1.19 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |   4.5173 ns | 0.0249 ns | 0.0233 ns |   4.5126 ns |  1.18 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |   3.7896 ns | 0.0114 ns | 0.0107 ns |   3.7911 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |   3.7912 ns | 0.0079 ns | 0.0074 ns |   3.7886 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |             |           |           |             |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 319.4056 ns | 2.3110 ns | 2.1617 ns | 318.3252 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
          To_String | .NET Core 2.2 | 273.5824 ns | 0.6256 ns | 0.5852 ns | 273.4889 ns |  0.86 |    0.01 | 0.0262 |     - |     - |     168 B |
          To_String | .NET Core 3.0 | 223.6267 ns | 0.9721 ns | 0.9093 ns | 223.9049 ns |  0.70 |    0.01 | 0.0100 |     - |     - |      64 B |
          To_String |        net461 | 320.1271 ns | 0.5136 ns | 0.4804 ns | 320.0895 ns |  1.00 |    0.01 | 0.0300 |     - |     - |     192 B |
          To_String |        net472 | 325.7450 ns | 1.5403 ns | 1.4408 ns | 326.2261 ns |  1.02 |    0.01 | 0.0300 |     - |     - |     192 B |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 |  12.4975 ns | 0.0106 ns | 0.0100 ns |  12.4945 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  12.0503 ns | 0.0652 ns | 0.0610 ns |  12.0691 ns |  0.96 |    0.01 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |   7.8846 ns | 0.0086 ns | 0.0081 ns |   7.8831 ns |  0.63 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 |  14.7076 ns | 0.0263 ns | 0.0246 ns |  14.7142 ns |  1.18 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 |  14.9288 ns | 0.0147 ns | 0.0138 ns |  14.9323 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  17.2615 ns | 0.0172 ns | 0.0152 ns |  17.2604 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  16.9553 ns | 0.0186 ns | 0.0165 ns |  16.9550 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |   8.0453 ns | 0.0686 ns | 0.0642 ns |   8.0921 ns |  0.47 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 |  20.6423 ns | 0.0223 ns | 0.0209 ns |  20.6391 ns |  1.20 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 |  20.7314 ns | 0.0187 ns | 0.0156 ns |  20.7334 ns |  1.20 |    0.00 |      - |     - |     - |         - |
