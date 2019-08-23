
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
             ToBool | .NET Core 2.0 |  0.8590 ns | 0.0060 ns | 0.0053 ns |  0.8577 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.1947 ns | 0.0033 ns | 0.0029 ns |  1.1949 ns |  1.39 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  0.9403 ns | 0.0029 ns | 0.0023 ns |  0.9400 ns |  1.10 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |  0.7209 ns | 0.0030 ns | 0.0026 ns |  0.7206 ns |  0.84 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |  0.7174 ns | 0.0020 ns | 0.0016 ns |  0.7171 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  3.9778 ns | 0.0035 ns | 0.0030 ns |  3.9786 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.1744 ns | 0.0079 ns | 0.0066 ns |  4.1738 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  3.9726 ns | 0.0083 ns | 0.0069 ns |  3.9711 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1705 ns | 0.0061 ns | 0.0054 ns |  4.1720 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1485 ns | 0.0050 ns | 0.0042 ns |  4.1496 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  2.7380 ns | 0.0093 ns | 0.0083 ns |  2.7365 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  2.7080 ns | 0.0090 ns | 0.0084 ns |  2.7072 ns |  0.99 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.9266 ns | 0.0044 ns | 0.0039 ns |  1.9267 ns |  0.70 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  1.6381 ns | 0.0146 ns | 0.0137 ns |  1.6347 ns |  0.60 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  1.6554 ns | 0.0037 ns | 0.0031 ns |  1.6550 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.7068 ns | 0.0070 ns | 0.0065 ns |  4.7048 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.8724 ns | 0.0081 ns | 0.0063 ns |  4.8714 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.4605 ns | 0.0030 ns | 0.0025 ns |  4.4609 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.8730 ns | 0.0063 ns | 0.0055 ns |  4.8735 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.8815 ns | 0.0261 ns | 0.0204 ns |  4.8904 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  2.3301 ns | 0.0025 ns | 0.0021 ns |  2.3298 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  2.5710 ns | 0.0063 ns | 0.0059 ns |  2.5710 ns |  1.10 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  2.2758 ns | 0.0118 ns | 0.0110 ns |  2.2790 ns |  0.98 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.6215 ns | 0.0028 ns | 0.0023 ns |  1.6214 ns |  0.70 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.6358 ns | 0.0038 ns | 0.0032 ns |  1.6364 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.7114 ns | 0.0052 ns | 0.0043 ns |  4.7130 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.8716 ns | 0.0081 ns | 0.0075 ns |  4.8715 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.4636 ns | 0.0079 ns | 0.0070 ns |  4.4615 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.8671 ns | 0.0068 ns | 0.0057 ns |  4.8672 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.8381 ns | 0.0091 ns | 0.0080 ns |  4.8374 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  2.5616 ns | 0.0045 ns | 0.0040 ns |  2.5618 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  2.7154 ns | 0.0074 ns | 0.0065 ns |  2.7145 ns |  1.06 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  2.2457 ns | 0.0159 ns | 0.0149 ns |  2.2474 ns |  0.88 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 |  1.6137 ns | 0.0029 ns | 0.0025 ns |  1.6138 ns |  0.63 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |  1.6591 ns | 0.0030 ns | 0.0028 ns |  1.6592 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.7140 ns | 0.0061 ns | 0.0054 ns |  4.7140 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.9186 ns | 0.0144 ns | 0.0127 ns |  4.9233 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.4371 ns | 0.0063 ns | 0.0059 ns |  4.4372 ns |  0.94 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.9244 ns | 0.0163 ns | 0.0136 ns |  4.9278 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.8411 ns | 0.0097 ns | 0.0091 ns |  4.8423 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  2.5628 ns | 0.0056 ns | 0.0053 ns |  2.5624 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  2.3336 ns | 0.0057 ns | 0.0050 ns |  2.3320 ns |  0.91 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.9495 ns | 0.0205 ns | 0.0192 ns |  1.9569 ns |  0.76 |    0.01 |      - |     - |     - |         - |
            ToShort |        net461 |  1.6445 ns | 0.0042 ns | 0.0037 ns |  1.6439 ns |  0.64 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  1.6573 ns | 0.0029 ns | 0.0024 ns |  1.6583 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.7087 ns | 0.0074 ns | 0.0065 ns |  4.7096 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.8722 ns | 0.0092 ns | 0.0081 ns |  4.8703 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.4627 ns | 0.0048 ns | 0.0043 ns |  4.4625 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.8715 ns | 0.0103 ns | 0.0091 ns |  4.8694 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.8410 ns | 0.0060 ns | 0.0053 ns |  4.8412 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  2.5928 ns | 0.0146 ns | 0.0129 ns |  2.5964 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  2.5952 ns | 0.0063 ns | 0.0056 ns |  2.5953 ns |  1.00 |    0.01 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  2.1891 ns | 0.0105 ns | 0.0093 ns |  2.1881 ns |  0.84 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |  1.8725 ns | 0.0036 ns | 0.0033 ns |  1.8724 ns |  0.72 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  1.8751 ns | 0.0032 ns | 0.0030 ns |  1.8759 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.7102 ns | 0.0069 ns | 0.0058 ns |  4.7104 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.8691 ns | 0.0064 ns | 0.0054 ns |  4.8677 ns |  1.03 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.4618 ns | 0.0053 ns | 0.0047 ns |  4.4626 ns |  0.95 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.8965 ns | 0.0317 ns | 0.0296 ns |  4.8816 ns |  1.04 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.8396 ns | 0.0069 ns | 0.0061 ns |  4.8393 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.1778 ns | 0.0018 ns | 0.0016 ns |  1.1772 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.1942 ns | 0.0057 ns | 0.0048 ns |  1.1959 ns |  1.01 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  0.9268 ns | 0.0033 ns | 0.0028 ns |  0.9260 ns |  0.79 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |  0.7065 ns | 0.0030 ns | 0.0027 ns |  0.7070 ns |  0.60 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  0.7138 ns | 0.0042 ns | 0.0037 ns |  0.7129 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.0130 ns | 0.0043 ns | 0.0041 ns |  4.0148 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.4068 ns | 0.0070 ns | 0.0058 ns |  4.4092 ns |  1.10 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.2370 ns | 0.0064 ns | 0.0060 ns |  4.2347 ns |  1.06 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.1884 ns | 0.0220 ns | 0.0206 ns |  4.1802 ns |  1.04 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.1501 ns | 0.0036 ns | 0.0032 ns |  4.1508 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.5531 ns | 0.0026 ns | 0.0024 ns |  1.5527 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.5100 ns | 0.0044 ns | 0.0034 ns |  1.5096 ns |  0.97 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  0.9599 ns | 0.0032 ns | 0.0030 ns |  0.9584 ns |  0.62 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |  1.6290 ns | 0.0049 ns | 0.0044 ns |  1.6295 ns |  1.05 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |  1.6645 ns | 0.0040 ns | 0.0037 ns |  1.6641 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.0235 ns | 0.0089 ns | 0.0083 ns |  4.0224 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.1791 ns | 0.0056 ns | 0.0050 ns |  4.1782 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  3.7762 ns | 0.0032 ns | 0.0029 ns |  3.7761 ns |  0.94 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.6358 ns | 0.0048 ns | 0.0045 ns |  4.6368 ns |  1.15 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.6065 ns | 0.0065 ns | 0.0058 ns |  4.6066 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.2534 ns | 0.0070 ns | 0.0062 ns |  1.2527 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.1712 ns | 0.0041 ns | 0.0036 ns |  1.1724 ns |  0.93 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  0.9399 ns | 0.0029 ns | 0.0026 ns |  0.9387 ns |  0.75 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |  0.7255 ns | 0.0162 ns | 0.0151 ns |  0.7187 ns |  0.58 |    0.01 |      - |     - |     - |         - |
             ToLong |        net472 |  0.7200 ns | 0.0017 ns | 0.0015 ns |  0.7197 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.6676 ns | 0.0036 ns | 0.0032 ns |  1.6676 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.9307 ns | 0.0036 ns | 0.0034 ns |  1.9317 ns |  1.16 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.7244 ns | 0.0037 ns | 0.0035 ns |  1.7240 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  1.9756 ns | 0.0026 ns | 0.0024 ns |  1.9759 ns |  1.18 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  1.7890 ns | 0.0036 ns | 0.0032 ns |  1.7884 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.5558 ns | 0.0045 ns | 0.0040 ns |  1.5562 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.5408 ns | 0.0110 ns | 0.0103 ns |  1.5375 ns |  0.99 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.0077 ns | 0.0026 ns | 0.0023 ns |  1.0077 ns |  0.65 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  1.9562 ns | 0.0656 ns | 0.0940 ns |  1.9657 ns |  1.26 |    0.07 |      - |     - |     - |         - |
            ToULong |        net472 |  1.6292 ns | 0.0016 ns | 0.0015 ns |  1.6292 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.2638 ns | 0.0058 ns | 0.0052 ns |  2.2644 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.3325 ns | 0.0043 ns | 0.0038 ns |  2.3328 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.6852 ns | 0.0033 ns | 0.0031 ns |  1.6840 ns |  0.74 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.7256 ns | 0.0054 ns | 0.0048 ns |  2.7262 ns |  1.20 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  2.5333 ns | 0.0261 ns | 0.0244 ns |  2.5404 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.1716 ns | 0.0030 ns | 0.0028 ns |  1.1712 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.4123 ns | 0.0041 ns | 0.0038 ns |  1.4110 ns |  1.21 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.1943 ns | 0.0111 ns | 0.0104 ns |  1.1970 ns |  1.02 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.7113 ns | 0.0093 ns | 0.0087 ns |  0.7076 ns |  0.61 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.7153 ns | 0.0023 ns | 0.0022 ns |  0.7159 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2411 ns | 0.0054 ns | 0.0042 ns |  4.2412 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4100 ns | 0.0075 ns | 0.0070 ns |  4.4092 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.1975 ns | 0.0062 ns | 0.0052 ns |  4.1974 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.4056 ns | 0.0073 ns | 0.0064 ns |  4.4068 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.3770 ns | 0.0057 ns | 0.0051 ns |  4.3756 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.3971 ns | 0.0034 ns | 0.0030 ns |  1.3980 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.4159 ns | 0.0026 ns | 0.0024 ns |  1.4163 ns |  1.01 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.2118 ns | 0.0168 ns | 0.0157 ns |  1.2041 ns |  0.87 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.6966 ns | 0.0044 ns | 0.0039 ns |  0.6955 ns |  0.50 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.7447 ns | 0.0083 ns | 0.0078 ns |  0.7487 ns |  0.53 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.9155 ns | 0.0068 ns | 0.0063 ns |  1.9150 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.9177 ns | 0.0053 ns | 0.0044 ns |  1.9177 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.7023 ns | 0.0039 ns | 0.0035 ns |  1.7018 ns |  0.89 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.7727 ns | 0.0025 ns | 0.0021 ns |  1.7729 ns |  0.93 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.5552 ns | 0.0028 ns | 0.0023 ns |  1.5549 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  5.8993 ns | 0.0289 ns | 0.0241 ns |  5.9073 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  5.8605 ns | 0.0063 ns | 0.0056 ns |  5.8590 ns |  0.99 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  5.8626 ns | 0.1103 ns | 0.1032 ns |  5.8040 ns |  1.00 |    0.02 |      - |     - |     - |         - |
          ToDecimal |        net461 |  5.7883 ns | 0.0098 ns | 0.0087 ns |  5.7855 ns |  0.98 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.0142 ns | 0.0322 ns | 0.0301 ns |  6.0021 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.1345 ns | 0.0212 ns | 0.0188 ns | 18.1367 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 17.8146 ns | 0.0337 ns | 0.0299 ns | 17.8142 ns |  0.98 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 12.6302 ns | 0.1240 ns | 0.1160 ns | 12.5576 ns |  0.70 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 17.7742 ns | 0.0303 ns | 0.0237 ns | 17.7869 ns |  0.98 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 25.8598 ns | 0.0353 ns | 0.0295 ns | 25.8610 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3156 ns | 0.0030 ns | 0.0027 ns |  2.3161 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3551 ns | 0.0071 ns | 0.0067 ns |  2.3561 ns |  1.02 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3393 ns | 0.0054 ns | 0.0051 ns |  2.3373 ns |  1.01 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1701 ns | 0.0032 ns | 0.0030 ns |  1.1707 ns |  0.51 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1248 ns | 0.0016 ns | 0.0015 ns |  1.1248 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.1967 ns | 0.0091 ns | 0.0080 ns |  8.1968 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  7.9885 ns | 0.0136 ns | 0.0121 ns |  7.9890 ns |  0.97 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9106 ns | 0.0150 ns | 0.0133 ns |  1.9147 ns |  0.23 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.7546 ns | 0.0340 ns | 0.0318 ns |  8.7580 ns |  1.07 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.2306 ns | 0.0503 ns | 0.0470 ns |  8.2583 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.4565 ns | 0.0219 ns | 0.0194 ns |  3.4520 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  3.7304 ns | 0.0138 ns | 0.0122 ns |  3.7275 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  3.7387 ns | 0.0266 ns | 0.0249 ns |  3.7392 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  2.7289 ns | 0.0219 ns | 0.0195 ns |  2.7207 ns |  0.79 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  2.7225 ns | 0.0086 ns | 0.0067 ns |  2.7225 ns |  0.79 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 29.8830 ns | 0.0481 ns | 0.0450 ns | 29.8886 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 17.3964 ns | 0.0413 ns | 0.0366 ns | 17.3958 ns |  0.58 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.1912 ns | 0.0230 ns | 0.0215 ns | 12.1869 ns |  0.41 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 31.0573 ns | 0.1614 ns | 0.1510 ns | 30.9891 ns |  1.04 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 30.6833 ns | 0.2040 ns | 0.1909 ns | 30.7910 ns |  1.03 |    0.01 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 12.0308 ns | 0.0326 ns | 0.0305 ns | 12.0232 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 11.8793 ns | 0.0139 ns | 0.0130 ns | 11.8775 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  7.9797 ns | 0.0208 ns | 0.0173 ns |  7.9711 ns |  0.66 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 14.8404 ns | 0.0935 ns | 0.0874 ns | 14.8330 ns |  1.23 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 | 15.4150 ns | 0.0318 ns | 0.0298 ns | 15.4028 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 16.5573 ns | 0.0537 ns | 0.0476 ns | 16.5371 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 16.7552 ns | 0.0721 ns | 0.0640 ns | 16.7664 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 12.5109 ns | 0.0540 ns | 0.0505 ns | 12.5336 ns |  0.76 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 19.0926 ns | 0.0320 ns | 0.0267 ns | 19.0926 ns |  1.15 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 19.1653 ns | 0.0333 ns | 0.0295 ns | 19.1557 ns |  1.16 |    0.00 |      - |     - |     - |         - |
