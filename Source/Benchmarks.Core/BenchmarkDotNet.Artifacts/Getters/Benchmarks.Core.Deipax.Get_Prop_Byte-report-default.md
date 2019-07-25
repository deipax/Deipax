
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FKBDAG : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-JDTBMX : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-AHQSCO : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-QYPIKG : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PVBQDT : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  1.2281 ns | 0.0601 ns | 0.0563 ns |  1.1973 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  0.9692 ns | 0.0028 ns | 0.0025 ns |  0.9689 ns |  0.80 |    0.03 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.1509 ns | 0.0164 ns | 0.0154 ns |  1.1540 ns |  0.94 |    0.04 |      - |     - |     - |         - |
             ToBool |        net461 |  0.4424 ns | 0.0055 ns | 0.0048 ns |  0.4419 ns |  0.36 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |  0.4330 ns | 0.0044 ns | 0.0039 ns |  0.4331 ns |  0.36 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.1558 ns | 0.1064 ns | 0.1384 ns |  4.0743 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.1820 ns | 0.0312 ns | 0.0291 ns |  4.1724 ns |  1.01 |    0.03 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0218 ns | 0.0139 ns | 0.0130 ns |  4.0231 ns |  0.97 |    0.03 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.2318 ns | 0.0227 ns | 0.0201 ns |  4.2253 ns |  1.02 |    0.03 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.2164 ns | 0.0220 ns | 0.0195 ns |  4.2126 ns |  1.02 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.2068 ns | 0.0090 ns | 0.0070 ns |  1.2089 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  0.8975 ns | 0.0057 ns | 0.0048 ns |  0.8983 ns |  0.74 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.1682 ns | 0.0064 ns | 0.0060 ns |  1.1670 ns |  0.97 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |  0.4825 ns | 0.0564 ns | 0.0603 ns |  0.4630 ns |  0.42 |    0.06 |      - |     - |     - |         - |
             ToChar |        net472 |  0.4476 ns | 0.0054 ns | 0.0048 ns |  0.4480 ns |  0.37 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.1810 ns | 0.1095 ns | 0.1570 ns |  4.0914 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.1688 ns | 0.0109 ns | 0.0102 ns |  4.1678 ns |  1.00 |    0.04 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0090 ns | 0.0108 ns | 0.0101 ns |  4.0091 ns |  0.96 |    0.03 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.3670 ns | 0.1275 ns | 0.1788 ns |  4.2874 ns |  1.05 |    0.05 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.1920 ns | 0.0088 ns | 0.0078 ns |  4.1908 ns |  1.01 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.5723 ns | 0.0576 ns | 0.0978 ns |  1.5013 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.4706 ns | 0.0053 ns | 0.0049 ns |  1.4693 ns |  0.95 |    0.05 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.1399 ns | 0.0119 ns | 0.0112 ns |  1.1439 ns |  0.73 |    0.04 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.3843 ns | 0.0051 ns | 0.0042 ns |  1.3845 ns |  0.89 |    0.05 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.3723 ns | 0.0114 ns | 0.0106 ns |  1.3692 ns |  0.88 |    0.05 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.1843 ns | 0.1089 ns | 0.1630 ns |  4.0941 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.2066 ns | 0.0258 ns | 0.0228 ns |  4.2156 ns |  1.00 |    0.04 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.0011 ns | 0.0099 ns | 0.0088 ns |  3.9982 ns |  0.95 |    0.04 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.9515 ns | 0.0134 ns | 0.0105 ns |  4.9528 ns |  1.18 |    0.05 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.8900 ns | 0.0054 ns | 0.0048 ns |  4.8892 ns |  1.16 |    0.05 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  1.1980 ns | 0.0140 ns | 0.0109 ns |  1.1955 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  0.8962 ns | 0.0063 ns | 0.0055 ns |  0.8941 ns |  0.75 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.1638 ns | 0.0051 ns | 0.0045 ns |  1.1639 ns |  0.97 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 |  0.4439 ns | 0.0070 ns | 0.0058 ns |  0.4433 ns |  0.37 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |  0.4476 ns | 0.0052 ns | 0.0049 ns |  0.4455 ns |  0.37 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.1444 ns | 0.0826 ns | 0.0733 ns |  4.1032 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.3971 ns | 0.0091 ns | 0.0081 ns |  4.3992 ns |  1.06 |    0.02 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.2534 ns | 0.0295 ns | 0.0276 ns |  4.2449 ns |  1.03 |    0.02 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.2656 ns | 0.0182 ns | 0.0171 ns |  4.2617 ns |  1.03 |    0.02 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.1926 ns | 0.0084 ns | 0.0070 ns |  4.1915 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.2057 ns | 0.0760 ns | 0.0673 ns |  1.1801 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  0.8951 ns | 0.0059 ns | 0.0049 ns |  0.8952 ns |  0.74 |    0.04 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.1451 ns | 0.0044 ns | 0.0037 ns |  1.1454 ns |  0.95 |    0.05 |      - |     - |     - |         - |
            ToShort |        net461 |  0.4376 ns | 0.0066 ns | 0.0058 ns |  0.4347 ns |  0.36 |    0.02 |      - |     - |     - |         - |
            ToShort |        net472 |  0.4346 ns | 0.0062 ns | 0.0055 ns |  0.4323 ns |  0.36 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.1785 ns | 0.1088 ns | 0.1336 ns |  4.1474 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.1680 ns | 0.0089 ns | 0.0079 ns |  4.1678 ns |  0.99 |    0.03 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.0097 ns | 0.0085 ns | 0.0079 ns |  4.0099 ns |  0.95 |    0.03 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.2175 ns | 0.0086 ns | 0.0080 ns |  4.2144 ns |  1.00 |    0.03 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.2096 ns | 0.0299 ns | 0.0279 ns |  4.1924 ns |  1.00 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.2190 ns | 0.0372 ns | 0.0311 ns |  1.2000 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.2911 ns | 0.0038 ns | 0.0035 ns |  1.2919 ns |  1.06 |    0.03 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.1632 ns | 0.0025 ns | 0.0024 ns |  1.1627 ns |  0.96 |    0.02 |      - |     - |     - |         - |
           ToUShort |        net461 |  0.4474 ns | 0.0076 ns | 0.0071 ns |  0.4449 ns |  0.37 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net472 |  0.4186 ns | 0.0032 ns | 0.0029 ns |  0.4179 ns |  0.34 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.1867 ns | 0.1099 ns | 0.1308 ns |  4.1729 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.1704 ns | 0.0123 ns | 0.0109 ns |  4.1668 ns |  1.01 |    0.03 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.0152 ns | 0.0095 ns | 0.0089 ns |  4.0128 ns |  0.97 |    0.03 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.2567 ns | 0.0409 ns | 0.0363 ns |  4.2388 ns |  1.03 |    0.03 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.2120 ns | 0.0222 ns | 0.0208 ns |  4.2040 ns |  1.02 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.2619 ns | 0.0512 ns | 0.0841 ns |  1.2134 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  0.8963 ns | 0.0047 ns | 0.0044 ns |  0.8972 ns |  0.71 |    0.05 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.1674 ns | 0.0188 ns | 0.0176 ns |  1.1620 ns |  0.92 |    0.07 |      - |     - |     - |         - |
              ToInt |        net461 |  0.4518 ns | 0.0132 ns | 0.0117 ns |  0.4487 ns |  0.35 |    0.02 |      - |     - |     - |         - |
              ToInt |        net472 |  0.4332 ns | 0.0093 ns | 0.0083 ns |  0.4331 ns |  0.34 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.2013 ns | 0.1071 ns | 0.1392 ns |  4.1560 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.1662 ns | 0.0087 ns | 0.0073 ns |  4.1664 ns |  0.99 |    0.03 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0121 ns | 0.0061 ns | 0.0054 ns |  4.0114 ns |  0.95 |    0.03 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.2359 ns | 0.0116 ns | 0.0097 ns |  4.2319 ns |  1.00 |    0.03 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.1925 ns | 0.0153 ns | 0.0128 ns |  4.1888 ns |  0.99 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.2016 ns | 0.0595 ns | 0.0497 ns |  1.1808 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  0.8969 ns | 0.0036 ns | 0.0034 ns |  0.8966 ns |  0.75 |    0.03 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.1648 ns | 0.0131 ns | 0.0116 ns |  1.1616 ns |  0.97 |    0.04 |      - |     - |     - |         - |
             ToUInt |        net461 |  0.4485 ns | 0.0059 ns | 0.0055 ns |  0.4472 ns |  0.37 |    0.02 |      - |     - |     - |         - |
             ToUInt |        net472 |  0.4333 ns | 0.0022 ns | 0.0018 ns |  0.4334 ns |  0.36 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.2176 ns | 0.1102 ns | 0.1471 ns |  4.1692 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.1668 ns | 0.0086 ns | 0.0072 ns |  4.1671 ns |  0.99 |    0.03 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0354 ns | 0.0086 ns | 0.0077 ns |  4.0330 ns |  0.96 |    0.03 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.2212 ns | 0.0127 ns | 0.0106 ns |  4.2192 ns |  1.00 |    0.03 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.1916 ns | 0.0084 ns | 0.0078 ns |  4.1907 ns |  0.99 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.3613 ns | 0.0525 ns | 0.0664 ns |  1.3694 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  0.9000 ns | 0.0040 ns | 0.0036 ns |  0.8992 ns |  0.67 |    0.04 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.1621 ns | 0.0037 ns | 0.0035 ns |  1.1613 ns |  0.87 |    0.05 |      - |     - |     - |         - |
             ToLong |        net461 |  0.4496 ns | 0.0229 ns | 0.0192 ns |  0.4410 ns |  0.34 |    0.02 |      - |     - |     - |         - |
             ToLong |        net472 |  0.4356 ns | 0.0065 ns | 0.0061 ns |  0.4366 ns |  0.32 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.7080 ns | 0.0071 ns | 0.0063 ns |  1.7067 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.4091 ns | 0.0151 ns | 0.0134 ns |  1.4145 ns |  0.82 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.8884 ns | 0.0672 ns | 0.1026 ns |  1.8393 ns |  1.09 |    0.04 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  1.7125 ns | 0.0480 ns | 0.0449 ns |  1.7061 ns |  1.00 |    0.03 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  1.5281 ns | 0.0057 ns | 0.0051 ns |  1.5278 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.1942 ns | 0.0232 ns | 0.0217 ns |  1.1824 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  0.8986 ns | 0.0054 ns | 0.0045 ns |  0.9011 ns |  0.75 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.1667 ns | 0.0137 ns | 0.0128 ns |  1.1708 ns |  0.98 |    0.02 |      - |     - |     - |         - |
            ToULong |        net461 |  0.4590 ns | 0.0214 ns | 0.0178 ns |  0.4549 ns |  0.39 |    0.01 |      - |     - |     - |         - |
            ToULong |        net472 |  0.4312 ns | 0.0029 ns | 0.0026 ns |  0.4314 ns |  0.36 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.7508 ns | 0.0033 ns | 0.0031 ns |  1.7511 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.5091 ns | 0.0081 ns | 0.0071 ns |  1.5093 ns |  0.86 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.6062 ns | 0.0264 ns | 0.0247 ns |  1.5933 ns |  0.92 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  1.6717 ns | 0.0361 ns | 0.0337 ns |  1.6697 ns |  0.95 |    0.02 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  1.4275 ns | 0.0124 ns | 0.0116 ns |  1.4248 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.1766 ns | 0.0028 ns | 0.0025 ns |  1.1768 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.1135 ns | 0.0064 ns | 0.0057 ns |  1.1119 ns |  0.95 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.1935 ns | 0.0238 ns | 0.0223 ns |  1.1829 ns |  1.01 |    0.02 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.4472 ns | 0.0036 ns | 0.0030 ns |  0.4468 ns |  0.38 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.4384 ns | 0.0016 ns | 0.0013 ns |  0.4385 ns |  0.37 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2868 ns | 0.0123 ns | 0.0109 ns |  4.2869 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4006 ns | 0.0095 ns | 0.0084 ns |  4.4007 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2922 ns | 0.0266 ns | 0.0236 ns |  4.2879 ns |  1.00 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.4997 ns | 0.0738 ns | 0.0690 ns |  4.4943 ns |  1.05 |    0.02 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.4419 ns | 0.0272 ns | 0.0254 ns |  4.4293 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.4199 ns | 0.0115 ns | 0.0102 ns |  1.4175 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.2189 ns | 0.0053 ns | 0.0047 ns |  1.2182 ns |  0.86 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.1758 ns | 0.0067 ns | 0.0056 ns |  1.1761 ns |  0.83 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.4504 ns | 0.0266 ns | 0.0235 ns |  0.4439 ns |  0.32 |    0.02 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.4317 ns | 0.0022 ns | 0.0018 ns |  0.4318 ns |  0.30 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.9506 ns | 0.0237 ns | 0.0221 ns |  1.9402 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.6637 ns | 0.0130 ns | 0.0115 ns |  1.6677 ns |  0.85 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.7678 ns | 0.0498 ns | 0.0466 ns |  1.7566 ns |  0.91 |    0.02 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.7084 ns | 0.0411 ns | 0.0365 ns |  1.7078 ns |  0.88 |    0.02 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.4249 ns | 0.0076 ns | 0.0071 ns |  1.4228 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  5.9003 ns | 0.0209 ns | 0.0186 ns |  5.8990 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  5.8064 ns | 0.0195 ns | 0.0182 ns |  5.8029 ns |  0.98 |    0.01 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  5.8991 ns | 0.0135 ns | 0.0120 ns |  5.8977 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  5.8370 ns | 0.0240 ns | 0.0213 ns |  5.8321 ns |  0.99 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net472 |  5.8297 ns | 0.0124 ns | 0.0110 ns |  5.8298 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.2802 ns | 0.0296 ns | 0.0262 ns | 18.2787 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 17.9533 ns | 0.0454 ns | 0.0402 ns | 17.9429 ns |  0.98 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 12.6863 ns | 0.0342 ns | 0.0267 ns | 12.6855 ns |  0.69 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.8140 ns | 0.0790 ns | 0.0739 ns | 18.8065 ns |  1.03 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.0617 ns | 0.0389 ns | 0.0364 ns | 18.0611 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3710 ns | 0.0049 ns | 0.0045 ns |  2.3696 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.0508 ns | 0.0048 ns | 0.0040 ns |  2.0499 ns |  0.87 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.2197 ns | 0.0136 ns | 0.0114 ns |  2.2166 ns |  0.94 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.2064 ns | 0.0067 ns | 0.0060 ns |  1.2063 ns |  0.51 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  0.9144 ns | 0.0053 ns | 0.0047 ns |  0.9135 ns |  0.39 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.0898 ns | 0.0231 ns | 0.0193 ns |  8.0883 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.2008 ns | 0.0190 ns | 0.0158 ns |  8.1937 ns |  1.01 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  2.0715 ns | 0.0383 ns | 0.0339 ns |  2.0581 ns |  0.26 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.2084 ns | 0.0178 ns | 0.0166 ns |  8.2059 ns |  1.01 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.0062 ns | 0.0218 ns | 0.0193 ns |  8.0037 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.2948 ns | 0.0303 ns | 0.0269 ns |  3.2876 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  3.6548 ns | 0.0151 ns | 0.0134 ns |  3.6536 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  3.8614 ns | 0.0476 ns | 0.0445 ns |  3.8461 ns |  1.17 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  2.7673 ns | 0.0201 ns | 0.0179 ns |  2.7640 ns |  0.84 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  2.9704 ns | 0.0153 ns | 0.0143 ns |  2.9689 ns |  0.90 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 32.0562 ns | 0.0640 ns | 0.0535 ns | 32.0536 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 17.3918 ns | 0.1040 ns | 0.0973 ns | 17.4265 ns |  0.54 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.2179 ns | 0.0929 ns | 0.0869 ns | 12.2077 ns |  0.38 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 30.6637 ns | 0.0840 ns | 0.0786 ns | 30.6446 ns |  0.96 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 31.0712 ns | 0.1035 ns | 0.0918 ns | 31.0505 ns |  0.97 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 10.1841 ns | 0.0221 ns | 0.0196 ns | 10.1838 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 10.3533 ns | 0.0209 ns | 0.0195 ns | 10.3543 ns |  1.02 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.3234 ns | 0.0211 ns | 0.0177 ns |  8.3205 ns |  0.82 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 12.2573 ns | 0.0282 ns | 0.0250 ns | 12.2624 ns |  1.20 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 12.3158 ns | 0.0774 ns | 0.0724 ns | 12.2820 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 14.6083 ns | 0.0902 ns | 0.0844 ns | 14.6440 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 15.0454 ns | 0.0275 ns | 0.0244 ns | 15.0496 ns |  1.03 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 12.7303 ns | 0.0380 ns | 0.0336 ns | 12.7248 ns |  0.87 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 16.8630 ns | 0.0283 ns | 0.0251 ns | 16.8605 ns |  1.15 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 16.9196 ns | 0.0285 ns | 0.0267 ns | 16.9180 ns |  1.16 |    0.01 |      - |     - |     - |         - |
