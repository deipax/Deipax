
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
             ToBool | .NET Core 2.0 |  1.1844 ns | 0.0031 ns | 0.0027 ns |  1.1843 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  0.8967 ns | 0.0071 ns | 0.0063 ns |  0.8971 ns |  0.76 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  0.9600 ns | 0.0024 ns | 0.0022 ns |  0.9596 ns |  0.81 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |  0.4292 ns | 0.0019 ns | 0.0018 ns |  0.4290 ns |  0.36 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |  0.4394 ns | 0.0025 ns | 0.0022 ns |  0.4391 ns |  0.37 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0132 ns | 0.0095 ns | 0.0089 ns |  4.0107 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.1404 ns | 0.0088 ns | 0.0073 ns |  4.1390 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0056 ns | 0.0079 ns | 0.0074 ns |  4.0062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1396 ns | 0.0052 ns | 0.0043 ns |  4.1400 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1637 ns | 0.0059 ns | 0.0055 ns |  4.1644 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.1894 ns | 0.0033 ns | 0.0030 ns |  1.1890 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  0.8924 ns | 0.0085 ns | 0.0075 ns |  0.8912 ns |  0.75 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.1008 ns | 0.0045 ns | 0.0040 ns |  1.1005 ns |  0.93 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  0.4304 ns | 0.0024 ns | 0.0022 ns |  0.4300 ns |  0.36 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  0.4492 ns | 0.0035 ns | 0.0031 ns |  0.4492 ns |  0.38 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.0279 ns | 0.0277 ns | 0.0246 ns |  4.0403 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.3725 ns | 0.0058 ns | 0.0054 ns |  4.3731 ns |  1.09 |    0.01 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.1760 ns | 0.0112 ns | 0.0105 ns |  4.1732 ns |  1.04 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.1841 ns | 0.0049 ns | 0.0044 ns |  4.1837 ns |  1.04 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.1693 ns | 0.0050 ns | 0.0047 ns |  4.1689 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.4616 ns | 0.0032 ns | 0.0028 ns |  1.4619 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.1795 ns | 0.0033 ns | 0.0030 ns |  1.1789 ns |  0.81 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.1006 ns | 0.0040 ns | 0.0033 ns |  1.0998 ns |  0.75 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.2479 ns | 0.0188 ns | 0.0176 ns |  1.2400 ns |  0.85 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.3627 ns | 0.0050 ns | 0.0044 ns |  1.3611 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.0109 ns | 0.0059 ns | 0.0052 ns |  4.0099 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.1466 ns | 0.0050 ns | 0.0045 ns |  4.1462 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  3.9361 ns | 0.0051 ns | 0.0048 ns |  3.9368 ns |  0.98 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.8323 ns | 0.0108 ns | 0.0096 ns |  4.8319 ns |  1.20 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.8597 ns | 0.0078 ns | 0.0073 ns |  4.8583 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  1.6443 ns | 0.0048 ns | 0.0043 ns |  1.6440 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.1804 ns | 0.0027 ns | 0.0024 ns |  1.1799 ns |  0.72 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.3337 ns | 0.0089 ns | 0.0079 ns |  1.3358 ns |  0.81 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |  1.3553 ns | 0.0041 ns | 0.0036 ns |  1.3546 ns |  0.82 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |  1.3875 ns | 0.0033 ns | 0.0031 ns |  1.3878 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.0450 ns | 0.0135 ns | 0.0113 ns |  4.0472 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.1449 ns | 0.0053 ns | 0.0049 ns |  4.1443 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.0014 ns | 0.0057 ns | 0.0053 ns |  3.9995 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.8328 ns | 0.0093 ns | 0.0083 ns |  4.8331 ns |  1.19 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.8607 ns | 0.0061 ns | 0.0057 ns |  4.8600 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.4740 ns | 0.0030 ns | 0.0026 ns |  1.4743 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.1803 ns | 0.0029 ns | 0.0027 ns |  1.1800 ns |  0.80 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.3111 ns | 0.0063 ns | 0.0052 ns |  1.3100 ns |  0.89 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |  1.3523 ns | 0.0028 ns | 0.0023 ns |  1.3517 ns |  0.92 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  1.3651 ns | 0.0034 ns | 0.0032 ns |  1.3649 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.0094 ns | 0.0045 ns | 0.0042 ns |  4.0099 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.1429 ns | 0.0070 ns | 0.0065 ns |  4.1426 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  3.9774 ns | 0.0184 ns | 0.0163 ns |  3.9822 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.8387 ns | 0.0134 ns | 0.0119 ns |  4.8367 ns |  1.21 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.8651 ns | 0.0075 ns | 0.0070 ns |  4.8636 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.1872 ns | 0.0024 ns | 0.0021 ns |  1.1876 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  0.8868 ns | 0.0030 ns | 0.0028 ns |  0.8857 ns |  0.75 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  0.9576 ns | 0.0021 ns | 0.0019 ns |  0.9575 ns |  0.81 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |  0.5772 ns | 0.0029 ns | 0.0028 ns |  0.5776 ns |  0.49 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  0.4410 ns | 0.0026 ns | 0.0023 ns |  0.4411 ns |  0.37 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.0058 ns | 0.0051 ns | 0.0045 ns |  4.0050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.1412 ns | 0.0109 ns | 0.0096 ns |  4.1367 ns |  1.03 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  3.9992 ns | 0.0050 ns | 0.0044 ns |  4.0001 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.1435 ns | 0.0093 ns | 0.0087 ns |  4.1419 ns |  1.03 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.1989 ns | 0.0309 ns | 0.0289 ns |  4.2083 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.1950 ns | 0.0022 ns | 0.0020 ns |  1.1956 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  0.8918 ns | 0.0028 ns | 0.0025 ns |  0.8912 ns |  0.75 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.0998 ns | 0.0019 ns | 0.0017 ns |  1.0997 ns |  0.92 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |  0.4258 ns | 0.0021 ns | 0.0019 ns |  0.4262 ns |  0.36 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  0.4400 ns | 0.0024 ns | 0.0021 ns |  0.4402 ns |  0.37 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.0078 ns | 0.0075 ns | 0.0067 ns |  4.0077 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.1365 ns | 0.0049 ns | 0.0046 ns |  4.1359 ns |  1.03 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0016 ns | 0.0073 ns | 0.0061 ns |  4.0011 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.1515 ns | 0.0057 ns | 0.0053 ns |  4.1522 ns |  1.04 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.1699 ns | 0.0081 ns | 0.0072 ns |  4.1708 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.1766 ns | 0.0073 ns | 0.0061 ns |  1.1791 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  0.8889 ns | 0.0032 ns | 0.0030 ns |  0.8877 ns |  0.76 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  0.9656 ns | 0.0090 ns | 0.0084 ns |  0.9667 ns |  0.82 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net461 |  0.4293 ns | 0.0041 ns | 0.0039 ns |  0.4299 ns |  0.36 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |  0.4387 ns | 0.0015 ns | 0.0014 ns |  0.4385 ns |  0.37 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.0112 ns | 0.0042 ns | 0.0035 ns |  4.0120 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.1370 ns | 0.0040 ns | 0.0037 ns |  4.1371 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  3.9407 ns | 0.0047 ns | 0.0044 ns |  3.9410 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.1409 ns | 0.0065 ns | 0.0061 ns |  4.1403 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.1668 ns | 0.0076 ns | 0.0071 ns |  4.1688 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.1666 ns | 0.0039 ns | 0.0035 ns |  1.1668 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  0.8971 ns | 0.0025 ns | 0.0023 ns |  0.8973 ns |  0.77 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  0.9580 ns | 0.0029 ns | 0.0026 ns |  0.9582 ns |  0.82 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |  0.4286 ns | 0.0019 ns | 0.0017 ns |  0.4288 ns |  0.37 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  0.4385 ns | 0.0014 ns | 0.0013 ns |  0.4384 ns |  0.38 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.8595 ns | 0.0042 ns | 0.0040 ns |  1.8594 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.3897 ns | 0.0027 ns | 0.0024 ns |  1.3892 ns |  0.75 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.5458 ns | 0.0036 ns | 0.0032 ns |  1.5458 ns |  0.83 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  1.6521 ns | 0.0069 ns | 0.0065 ns |  1.6514 ns |  0.89 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  1.8740 ns | 0.0038 ns | 0.0034 ns |  1.8735 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.1658 ns | 0.0044 ns | 0.0039 ns |  1.1649 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  0.9007 ns | 0.0016 ns | 0.0014 ns |  0.9005 ns |  0.77 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  0.9601 ns | 0.0019 ns | 0.0017 ns |  0.9601 ns |  0.82 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  0.4295 ns | 0.0017 ns | 0.0015 ns |  0.4297 ns |  0.37 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  0.4398 ns | 0.0014 ns | 0.0013 ns |  0.4394 ns |  0.38 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.7877 ns | 0.0024 ns | 0.0021 ns |  1.7869 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.5654 ns | 0.0023 ns | 0.0020 ns |  1.5659 ns |  0.88 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.8837 ns | 0.0153 ns | 0.0135 ns |  1.8879 ns |  1.05 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  1.4363 ns | 0.0074 ns | 0.0069 ns |  1.4375 ns |  0.80 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  1.6102 ns | 0.0028 ns | 0.0023 ns |  1.6103 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.1652 ns | 0.0038 ns | 0.0034 ns |  1.1651 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  0.9173 ns | 0.0082 ns | 0.0073 ns |  0.9173 ns |  0.79 |    0.01 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.1634 ns | 0.0022 ns | 0.0018 ns |  1.1630 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.4264 ns | 0.0021 ns | 0.0019 ns |  0.4259 ns |  0.37 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.4396 ns | 0.0017 ns | 0.0016 ns |  0.4395 ns |  0.38 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2373 ns | 0.0088 ns | 0.0083 ns |  4.2364 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.3764 ns | 0.0120 ns | 0.0107 ns |  4.3758 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.0330 ns | 0.0134 ns | 0.0119 ns |  4.0350 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.3712 ns | 0.0065 ns | 0.0054 ns |  4.3720 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.4403 ns | 0.0197 ns | 0.0165 ns |  4.4441 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.1657 ns | 0.0028 ns | 0.0025 ns |  1.1652 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  0.9456 ns | 0.0043 ns | 0.0040 ns |  0.9453 ns |  0.81 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  0.9680 ns | 0.0016 ns | 0.0014 ns |  0.9676 ns |  0.83 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.4267 ns | 0.0021 ns | 0.0018 ns |  0.4272 ns |  0.37 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.6112 ns | 0.0041 ns | 0.0039 ns |  0.6102 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.7333 ns | 0.0050 ns | 0.0046 ns |  1.7325 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.5682 ns | 0.0047 ns | 0.0041 ns |  1.5669 ns |  0.91 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.6979 ns | 0.0145 ns | 0.0129 ns |  1.7001 ns |  0.98 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.4439 ns | 0.0031 ns | 0.0028 ns |  1.4436 ns |  0.83 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.6440 ns | 0.0030 ns | 0.0027 ns |  1.6440 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  3.4693 ns | 0.0061 ns | 0.0054 ns |  3.4691 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.8335 ns | 0.0041 ns | 0.0037 ns |  2.8332 ns |  0.82 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  3.0224 ns | 0.0058 ns | 0.0054 ns |  3.0222 ns |  0.87 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  5.9902 ns | 0.0086 ns | 0.0077 ns |  5.9907 ns |  1.73 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  5.7836 ns | 0.0058 ns | 0.0055 ns |  5.7839 ns |  1.67 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  2.1813 ns | 0.0688 ns | 0.0918 ns |  2.1658 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  1.4683 ns | 0.0023 ns | 0.0020 ns |  1.4678 ns |  0.67 |    0.03 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  1.7683 ns | 0.0037 ns | 0.0032 ns |  1.7689 ns |  0.80 |    0.03 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |  1.4026 ns | 0.0030 ns | 0.0025 ns |  1.4022 ns |  0.63 |    0.03 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |  1.6252 ns | 0.0033 ns | 0.0031 ns |  1.6246 ns |  0.74 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3456 ns | 0.0052 ns | 0.0049 ns |  2.3451 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.0359 ns | 0.0026 ns | 0.0022 ns |  2.0362 ns |  0.87 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  1.8556 ns | 0.0071 ns | 0.0063 ns |  1.8527 ns |  0.79 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1306 ns | 0.0049 ns | 0.0041 ns |  1.1311 ns |  0.48 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1828 ns | 0.0018 ns | 0.0017 ns |  1.1830 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.0155 ns | 0.0079 ns | 0.0073 ns |  8.0160 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.1469 ns | 0.0129 ns | 0.0108 ns |  8.1454 ns |  1.02 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9381 ns | 0.0106 ns | 0.0099 ns |  1.9395 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  7.9820 ns | 0.0112 ns | 0.0105 ns |  7.9830 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  7.9520 ns | 0.0107 ns | 0.0100 ns |  7.9482 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.4626 ns | 0.0178 ns | 0.0158 ns |  3.4572 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  3.6925 ns | 0.0231 ns | 0.0205 ns |  3.6835 ns |  1.07 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  3.7761 ns | 0.0335 ns | 0.0313 ns |  3.7818 ns |  1.09 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  2.7637 ns | 0.0053 ns | 0.0049 ns |  2.7635 ns |  0.80 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  2.6644 ns | 0.0067 ns | 0.0056 ns |  2.6629 ns |  0.77 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 |  5.0679 ns | 0.0118 ns | 0.0098 ns |  5.0645 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 |  4.3259 ns | 0.0063 ns | 0.0055 ns |  4.3260 ns |  0.85 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 |  4.4873 ns | 0.1140 ns | 0.1268 ns |  4.5271 ns |  0.88 |    0.03 | 0.0038 |     - |     - |      24 B |
          To_String |        net461 |  5.2064 ns | 0.0219 ns | 0.0194 ns |  5.2016 ns |  1.03 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 |  5.4930 ns | 0.0128 ns | 0.0114 ns |  5.4903 ns |  1.08 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 |  9.9488 ns | 0.0164 ns | 0.0145 ns |  9.9468 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 10.2871 ns | 0.0125 ns | 0.0110 ns | 10.2861 ns |  1.03 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.3099 ns | 0.0126 ns | 0.0098 ns |  8.3085 ns |  0.84 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 12.2893 ns | 0.0300 ns | 0.0280 ns | 12.2818 ns |  1.23 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 12.1062 ns | 0.0109 ns | 0.0097 ns | 12.1041 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 14.4226 ns | 0.0135 ns | 0.0126 ns | 14.4229 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 15.0153 ns | 0.0259 ns | 0.0216 ns | 15.0197 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 12.8401 ns | 0.0127 ns | 0.0119 ns | 12.8367 ns |  0.89 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 16.7106 ns | 0.0147 ns | 0.0130 ns | 16.7081 ns |  1.16 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 16.7471 ns | 0.0195 ns | 0.0182 ns | 16.7492 ns |  1.16 |    0.00 |      - |     - |     - |         - |
