
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
             ToBool | .NET Core 2.0 |  1.1790 ns | 0.0100 ns | 0.0089 ns |  1.1817 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.1911 ns | 0.0034 ns | 0.0032 ns |  1.1907 ns |  1.01 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  0.9634 ns | 0.0036 ns | 0.0034 ns |  0.9630 ns |  0.82 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |  0.7201 ns | 0.0025 ns | 0.0023 ns |  0.7202 ns |  0.61 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |  0.7193 ns | 0.0026 ns | 0.0023 ns |  0.7194 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  3.9473 ns | 0.0052 ns | 0.0049 ns |  3.9470 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.1839 ns | 0.0099 ns | 0.0093 ns |  4.1817 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0019 ns | 0.0056 ns | 0.0052 ns |  4.0031 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1522 ns | 0.0055 ns | 0.0052 ns |  4.1522 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.2254 ns | 0.0117 ns | 0.0109 ns |  4.2272 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.1819 ns | 0.0068 ns | 0.0064 ns |  1.1830 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.2176 ns | 0.0031 ns | 0.0027 ns |  1.2176 ns |  1.03 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  0.9612 ns | 0.0145 ns | 0.0135 ns |  0.9660 ns |  0.81 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |  0.7290 ns | 0.0109 ns | 0.0102 ns |  0.7238 ns |  0.62 |    0.01 |      - |     - |     - |         - |
             ToChar |        net472 |  0.7206 ns | 0.0026 ns | 0.0022 ns |  0.7205 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  3.9509 ns | 0.0110 ns | 0.0097 ns |  3.9496 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.2211 ns | 0.0192 ns | 0.0179 ns |  4.2239 ns |  1.07 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0044 ns | 0.0078 ns | 0.0069 ns |  4.0033 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.1658 ns | 0.0235 ns | 0.0220 ns |  4.1573 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.1782 ns | 0.0063 ns | 0.0056 ns |  4.1772 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.4732 ns | 0.0116 ns | 0.0109 ns |  1.4763 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.6505 ns | 0.0034 ns | 0.0030 ns |  1.6513 ns |  1.12 |    0.01 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.1892 ns | 0.0026 ns | 0.0023 ns |  1.1886 ns |  0.81 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.6561 ns | 0.0015 ns | 0.0014 ns |  1.6559 ns |  1.12 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.6265 ns | 0.0034 ns | 0.0031 ns |  1.6273 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  3.9504 ns | 0.0077 ns | 0.0072 ns |  3.9511 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.1792 ns | 0.0062 ns | 0.0058 ns |  4.1792 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.0068 ns | 0.0133 ns | 0.0118 ns |  4.0022 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.7226 ns | 0.0101 ns | 0.0094 ns |  4.7204 ns |  1.20 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.8681 ns | 0.0060 ns | 0.0056 ns |  4.8682 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  1.7800 ns | 0.0122 ns | 0.0108 ns |  1.7821 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.6516 ns | 0.0047 ns | 0.0044 ns |  1.6514 ns |  0.93 |    0.01 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.0217 ns | 0.0012 ns | 0.0010 ns |  1.0214 ns |  0.57 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |  1.6574 ns | 0.0042 ns | 0.0038 ns |  1.6573 ns |  0.93 |    0.01 |      - |     - |     - |         - |
             ToByte |        net472 |  1.6416 ns | 0.0118 ns | 0.0111 ns |  1.6458 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  3.9520 ns | 0.0078 ns | 0.0073 ns |  3.9518 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.1858 ns | 0.0077 ns | 0.0072 ns |  4.1867 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.0047 ns | 0.0086 ns | 0.0076 ns |  4.0026 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.8851 ns | 0.0213 ns | 0.0189 ns |  4.8885 ns |  1.24 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.8642 ns | 0.0055 ns | 0.0049 ns |  4.8633 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.4446 ns | 0.0032 ns | 0.0027 ns |  1.4447 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.4778 ns | 0.0039 ns | 0.0034 ns |  1.4779 ns |  1.02 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.0277 ns | 0.0030 ns | 0.0026 ns |  1.0270 ns |  0.71 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |  1.6440 ns | 0.0031 ns | 0.0027 ns |  1.6437 ns |  1.14 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  1.6436 ns | 0.0023 ns | 0.0021 ns |  1.6435 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  3.9466 ns | 0.0074 ns | 0.0069 ns |  3.9449 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.1851 ns | 0.0180 ns | 0.0160 ns |  4.1801 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.0072 ns | 0.0065 ns | 0.0060 ns |  4.0076 ns |  1.02 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.8622 ns | 0.0310 ns | 0.0290 ns |  4.8470 ns |  1.23 |    0.01 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.8658 ns | 0.0061 ns | 0.0057 ns |  4.8636 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.1748 ns | 0.0041 ns | 0.0036 ns |  1.1734 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.2072 ns | 0.0021 ns | 0.0017 ns |  1.2074 ns |  1.03 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  0.9687 ns | 0.0035 ns | 0.0032 ns |  0.9678 ns |  0.82 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |  0.7217 ns | 0.0028 ns | 0.0026 ns |  0.7221 ns |  0.61 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  0.7196 ns | 0.0024 ns | 0.0020 ns |  0.7198 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  3.9928 ns | 0.0180 ns | 0.0160 ns |  3.9937 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.4203 ns | 0.0186 ns | 0.0155 ns |  4.4181 ns |  1.11 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.2288 ns | 0.0070 ns | 0.0062 ns |  4.2277 ns |  1.06 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.1585 ns | 0.0155 ns | 0.0129 ns |  4.1548 ns |  1.04 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.2239 ns | 0.0083 ns | 0.0073 ns |  4.2221 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.1734 ns | 0.0019 ns | 0.0018 ns |  1.1734 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.1890 ns | 0.0042 ns | 0.0037 ns |  1.1889 ns |  1.01 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  0.9708 ns | 0.0078 ns | 0.0065 ns |  0.9729 ns |  0.83 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |  0.7188 ns | 0.0033 ns | 0.0030 ns |  0.7185 ns |  0.61 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  0.7051 ns | 0.0023 ns | 0.0018 ns |  0.7055 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  3.9502 ns | 0.0052 ns | 0.0048 ns |  3.9501 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.1812 ns | 0.0054 ns | 0.0051 ns |  4.1806 ns |  1.06 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0024 ns | 0.0055 ns | 0.0046 ns |  4.0016 ns |  1.01 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.1533 ns | 0.0039 ns | 0.0034 ns |  4.1539 ns |  1.05 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.1742 ns | 0.0050 ns | 0.0047 ns |  4.1734 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.0926 ns | 0.0022 ns | 0.0019 ns |  1.0923 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.1898 ns | 0.0027 ns | 0.0024 ns |  1.1903 ns |  1.09 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  0.9603 ns | 0.0050 ns | 0.0041 ns |  0.9606 ns |  0.88 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |  0.7430 ns | 0.0188 ns | 0.0176 ns |  0.7328 ns |  0.68 |    0.02 |      - |     - |     - |         - |
             ToUInt |        net472 |  0.7048 ns | 0.0018 ns | 0.0017 ns |  0.7044 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  3.9498 ns | 0.0050 ns | 0.0047 ns |  3.9504 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.1793 ns | 0.0070 ns | 0.0062 ns |  4.1803 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  3.9993 ns | 0.0041 ns | 0.0036 ns |  3.9998 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.1529 ns | 0.0058 ns | 0.0052 ns |  4.1541 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.1852 ns | 0.0099 ns | 0.0088 ns |  4.1846 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.0914 ns | 0.0035 ns | 0.0031 ns |  1.0909 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.1901 ns | 0.0028 ns | 0.0025 ns |  1.1901 ns |  1.09 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  0.9597 ns | 0.0040 ns | 0.0036 ns |  0.9599 ns |  0.88 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |  0.7211 ns | 0.0038 ns | 0.0032 ns |  0.7207 ns |  0.66 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  0.7207 ns | 0.0020 ns | 0.0018 ns |  0.7202 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.5750 ns | 0.0032 ns | 0.0026 ns |  1.5759 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.7519 ns | 0.0072 ns | 0.0067 ns |  1.7535 ns |  1.11 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.8942 ns | 0.0151 ns | 0.0133 ns |  1.8986 ns |  1.20 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  1.8639 ns | 0.0030 ns | 0.0027 ns |  1.8626 ns |  1.18 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  1.8508 ns | 0.0065 ns | 0.0057 ns |  1.8490 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.1071 ns | 0.0031 ns | 0.0026 ns |  1.1069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.2181 ns | 0.0028 ns | 0.0026 ns |  1.2178 ns |  1.10 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  0.9585 ns | 0.0033 ns | 0.0031 ns |  0.9594 ns |  0.87 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  0.7314 ns | 0.0081 ns | 0.0076 ns |  0.7321 ns |  0.66 |    0.01 |      - |     - |     - |         - |
            ToULong |        net472 |  0.7317 ns | 0.0025 ns | 0.0021 ns |  0.7317 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.6015 ns | 0.0049 ns | 0.0043 ns |  1.6016 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.8055 ns | 0.0065 ns | 0.0057 ns |  1.8051 ns |  1.13 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.8902 ns | 0.0037 ns | 0.0035 ns |  1.8909 ns |  1.18 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  1.5797 ns | 0.0040 ns | 0.0036 ns |  1.5801 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  1.6999 ns | 0.0044 ns | 0.0041 ns |  1.6996 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.1079 ns | 0.0027 ns | 0.0022 ns |  1.1080 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.6137 ns | 0.0049 ns | 0.0041 ns |  1.6141 ns |  1.46 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.1273 ns | 0.0039 ns | 0.0037 ns |  1.1259 ns |  1.02 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.7119 ns | 0.0035 ns | 0.0031 ns |  0.7114 ns |  0.64 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.7089 ns | 0.0036 ns | 0.0034 ns |  0.7079 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.1782 ns | 0.0072 ns | 0.0067 ns |  4.1782 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4163 ns | 0.0104 ns | 0.0092 ns |  4.4158 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2349 ns | 0.0063 ns | 0.0056 ns |  4.2346 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.4231 ns | 0.0052 ns | 0.0043 ns |  4.4228 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.4059 ns | 0.0070 ns | 0.0066 ns |  4.4035 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.3236 ns | 0.0032 ns | 0.0026 ns |  1.3235 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.7768 ns | 0.0030 ns | 0.0026 ns |  1.7768 ns |  1.34 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.5296 ns | 0.0030 ns | 0.0025 ns |  1.5303 ns |  1.16 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.7460 ns | 0.0180 ns | 0.0168 ns |  0.7342 ns |  0.57 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.7108 ns | 0.0026 ns | 0.0025 ns |  0.7099 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.7773 ns | 0.0045 ns | 0.0040 ns |  1.7761 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.6781 ns | 0.0046 ns | 0.0036 ns |  1.6788 ns |  0.94 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.8804 ns | 0.0047 ns | 0.0044 ns |  1.8814 ns |  1.06 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.5609 ns | 0.0040 ns | 0.0035 ns |  1.5607 ns |  0.88 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.7375 ns | 0.0030 ns | 0.0025 ns |  1.7375 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  5.7788 ns | 0.0108 ns | 0.0090 ns |  5.7765 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  5.7924 ns | 0.0048 ns | 0.0043 ns |  5.7916 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  5.8359 ns | 0.0125 ns | 0.0117 ns |  5.8331 ns |  1.01 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  5.8023 ns | 0.0388 ns | 0.0363 ns |  5.7734 ns |  1.00 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net472 |  5.7886 ns | 0.0063 ns | 0.0056 ns |  5.7886 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.0804 ns | 0.0248 ns | 0.0232 ns | 18.0702 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.0450 ns | 0.0269 ns | 0.0225 ns | 18.0536 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 12.6881 ns | 0.1427 ns | 0.1335 ns | 12.7668 ns |  0.70 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.0074 ns | 0.0117 ns | 0.0109 ns | 18.0129 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.9314 ns | 0.0203 ns | 0.0190 ns | 18.9382 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.0319 ns | 0.0043 ns | 0.0036 ns |  2.0322 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3708 ns | 0.0051 ns | 0.0048 ns |  2.3701 ns |  1.17 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3419 ns | 0.0050 ns | 0.0046 ns |  2.3407 ns |  1.15 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1295 ns | 0.0150 ns | 0.0140 ns |  1.1223 ns |  0.55 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1705 ns | 0.0026 ns | 0.0024 ns |  1.1711 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.7010 ns | 0.0127 ns | 0.0119 ns |  7.6989 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.0537 ns | 0.0098 ns | 0.0087 ns |  8.0557 ns |  1.05 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9261 ns | 0.0025 ns | 0.0023 ns |  1.9264 ns |  0.25 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.6164 ns | 0.0246 ns | 0.0230 ns |  8.6105 ns |  1.12 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 | 12.3929 ns | 0.0447 ns | 0.0418 ns | 12.3966 ns |  1.61 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.3208 ns | 0.0077 ns | 0.0068 ns |  3.3205 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  3.7718 ns | 0.0234 ns | 0.0195 ns |  3.7651 ns |  1.14 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  3.8170 ns | 0.0361 ns | 0.0320 ns |  3.8014 ns |  1.15 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  2.6925 ns | 0.0067 ns | 0.0056 ns |  2.6939 ns |  0.81 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  2.7004 ns | 0.0100 ns | 0.0084 ns |  2.7011 ns |  0.81 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 26.4191 ns | 0.0448 ns | 0.0397 ns | 26.4227 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 16.9759 ns | 0.0714 ns | 0.0668 ns | 16.9625 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.7461 ns | 0.0216 ns | 0.0202 ns | 12.7439 ns |  0.48 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 29.8047 ns | 0.0539 ns | 0.0478 ns | 29.8000 ns |  1.13 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 30.2981 ns | 0.0696 ns | 0.0617 ns | 30.2940 ns |  1.15 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 10.0499 ns | 0.0444 ns | 0.0415 ns | 10.0573 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 10.2117 ns | 0.0112 ns | 0.0100 ns | 10.2094 ns |  1.02 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.2246 ns | 0.0127 ns | 0.0106 ns |  8.2255 ns |  0.82 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 12.1696 ns | 0.0613 ns | 0.0574 ns | 12.1384 ns |  1.21 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 | 12.1169 ns | 0.0095 ns | 0.0089 ns | 12.1171 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 14.4294 ns | 0.0365 ns | 0.0324 ns | 14.4232 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 14.8242 ns | 0.0125 ns | 0.0111 ns | 14.8253 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 12.7489 ns | 0.0117 ns | 0.0109 ns | 12.7494 ns |  0.88 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 16.9468 ns | 0.1026 ns | 0.0910 ns | 16.9602 ns |  1.17 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 16.9732 ns | 0.0912 ns | 0.0853 ns | 16.9894 ns |  1.18 |    0.01 |      - |     - |     - |         - |
