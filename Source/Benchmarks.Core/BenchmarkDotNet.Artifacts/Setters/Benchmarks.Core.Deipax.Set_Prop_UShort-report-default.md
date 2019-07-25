
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-JBIYRV : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-GQVRNQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-BKGSYN : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-NLOXWC : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-AAMQWS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  0.9410 ns | 0.0062 ns | 0.0058 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  1.2082 ns | 0.0026 ns | 0.0020 ns |  1.28 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  1.1768 ns | 0.0036 ns | 0.0033 ns |  1.25 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  1.1893 ns | 0.0049 ns | 0.0045 ns |  1.26 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9114 ns | 0.0029 ns | 0.0023 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.4096 ns | 0.0058 ns | 0.0055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.4423 ns | 0.0094 ns | 0.0088 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9887 ns | 0.0155 ns | 0.0145 ns |  0.70 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.6856 ns | 0.0031 ns | 0.0027 ns |  1.20 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.6604 ns | 0.0037 ns | 0.0033 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.7040 ns | 0.0051 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.7599 ns | 0.0027 ns | 0.0024 ns |  1.08 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.7058 ns | 0.0031 ns | 0.0029 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.7184 ns | 0.0039 ns | 0.0032 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  0.4551 ns | 0.0054 ns | 0.0051 ns |  0.65 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.1679 ns | 0.0058 ns | 0.0054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.2049 ns | 0.0058 ns | 0.0054 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.9698 ns | 0.0069 ns | 0.0061 ns |  0.83 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.6604 ns | 0.0048 ns | 0.0043 ns |  1.42 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.6374 ns | 0.0048 ns | 0.0045 ns |  1.40 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.1934 ns | 0.0036 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.1265 ns | 0.0084 ns | 0.0079 ns |  0.94 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.5094 ns | 0.0058 ns | 0.0055 ns |  0.43 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.6918 ns | 0.0066 ns | 0.0062 ns |  1.42 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.6133 ns | 0.0053 ns | 0.0050 ns |  1.35 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.5462 ns | 0.0215 ns | 0.0201 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.5206 ns | 0.0054 ns | 0.0051 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.1700 ns | 0.0041 ns | 0.0036 ns |  0.76 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.3746 ns | 0.0079 ns | 0.0074 ns |  1.54 |    0.02 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.2200 ns | 0.0040 ns | 0.0036 ns |  1.44 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.7027 ns | 0.0032 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7413 ns | 0.0040 ns | 0.0038 ns |  1.06 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.7035 ns | 0.0082 ns | 0.0073 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.7292 ns | 0.0114 ns | 0.0107 ns |  1.04 |    0.02 |     - |     - |     - |         - |
             FromByte |        net472 |  0.4481 ns | 0.0029 ns | 0.0026 ns |  0.64 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.1730 ns | 0.0057 ns | 0.0054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9733 ns | 0.0037 ns | 0.0033 ns |  0.83 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.1727 ns | 0.0044 ns | 0.0037 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  2.0632 ns | 0.0080 ns | 0.0071 ns |  1.76 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.6851 ns | 0.0040 ns | 0.0035 ns |  1.44 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.1973 ns | 0.0071 ns | 0.0067 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.2075 ns | 0.0056 ns | 0.0052 ns |  1.01 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.7033 ns | 0.0054 ns | 0.0048 ns |  0.59 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.8956 ns | 0.0063 ns | 0.0059 ns |  1.58 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  1.8150 ns | 0.0075 ns | 0.0066 ns |  1.51 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.6582 ns | 0.0035 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.6551 ns | 0.0049 ns | 0.0041 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1705 ns | 0.0030 ns | 0.0027 ns |  0.71 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.3525 ns | 0.0063 ns | 0.0059 ns |  1.42 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.1584 ns | 0.0049 ns | 0.0041 ns |  1.30 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.7100 ns | 0.0039 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.7619 ns | 0.0030 ns | 0.0027 ns |  1.07 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.4995 ns | 0.0076 ns | 0.0071 ns |  0.70 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.7180 ns | 0.0027 ns | 0.0026 ns |  1.01 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.4441 ns | 0.0019 ns | 0.0016 ns |  0.63 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.1713 ns | 0.0033 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.2262 ns | 0.0085 ns | 0.0079 ns |  1.05 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  0.9700 ns | 0.0063 ns | 0.0052 ns |  0.83 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.8594 ns | 0.0679 ns | 0.1387 ns |  1.62 |    0.11 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.4063 ns | 0.0045 ns | 0.0038 ns |  1.20 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.8630 ns | 0.0035 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.9326 ns | 0.0032 ns | 0.0027 ns |  1.04 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.6377 ns | 0.0117 ns | 0.0110 ns |  0.88 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  2.1582 ns | 0.0150 ns | 0.0141 ns |  1.16 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  1.8538 ns | 0.0055 ns | 0.0049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.5510 ns | 0.0051 ns | 0.0048 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  2.1429 ns | 0.0043 ns | 0.0041 ns |  0.84 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.7999 ns | 0.0146 ns | 0.0137 ns |  0.71 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.6144 ns | 0.0066 ns | 0.0062 ns |  1.02 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.3204 ns | 0.0091 ns | 0.0076 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.6937 ns | 0.0601 ns | 0.0953 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.1826 ns | 0.0104 ns | 0.0097 ns |  0.70 |    0.03 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.6828 ns | 0.0108 ns | 0.0101 ns |  0.40 |    0.02 |     - |     - |     - |         - |
             FromUInt |        net461 |  2.1448 ns | 0.0100 ns | 0.0083 ns |  1.27 |    0.05 |     - |     - |     - |         - |
             FromUInt |        net472 |  2.1513 ns | 0.0037 ns | 0.0035 ns |  1.27 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.7699 ns | 0.0040 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.6574 ns | 0.0054 ns | 0.0050 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.1478 ns | 0.0043 ns | 0.0036 ns |  0.65 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.6345 ns | 0.0063 ns | 0.0056 ns |  1.49 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.5940 ns | 0.0066 ns | 0.0062 ns |  1.47 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.6462 ns | 0.0073 ns | 0.0069 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.7377 ns | 0.0188 ns | 0.0175 ns |  1.06 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.8505 ns | 0.0038 ns | 0.0035 ns |  1.12 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.9008 ns | 0.0034 ns | 0.0027 ns |  1.15 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  1.8909 ns | 0.0082 ns | 0.0076 ns |  1.15 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  2.4699 ns | 0.0093 ns | 0.0087 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  2.9199 ns | 0.0185 ns | 0.0173 ns |  1.18 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  2.6548 ns | 0.0063 ns | 0.0059 ns |  1.07 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.8843 ns | 0.0047 ns | 0.0044 ns |  1.17 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.9225 ns | 0.0068 ns | 0.0060 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.8782 ns | 0.0028 ns | 0.0022 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.6907 ns | 0.0061 ns | 0.0051 ns |  0.90 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.6398 ns | 0.0052 ns | 0.0048 ns |  0.87 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.9276 ns | 0.0043 ns | 0.0038 ns |  1.03 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.8909 ns | 0.0125 ns | 0.0117 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.9256 ns | 0.0069 ns | 0.0064 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  3.0467 ns | 0.0064 ns | 0.0057 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  2.9675 ns | 0.0141 ns | 0.0125 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.8739 ns | 0.0175 ns | 0.0155 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.9637 ns | 0.0063 ns | 0.0059 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.8179 ns | 0.0110 ns | 0.0092 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.9140 ns | 0.0099 ns | 0.0092 ns |  1.03 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  4.1459 ns | 0.0073 ns | 0.0068 ns |  1.09 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  4.1173 ns | 0.0053 ns | 0.0041 ns |  1.08 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.8770 ns | 0.0064 ns | 0.0053 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  4.6550 ns | 0.0113 ns | 0.0100 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  4.7679 ns | 0.0042 ns | 0.0033 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  5.1649 ns | 0.0189 ns | 0.0176 ns |  1.11 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  4.2977 ns | 0.0378 ns | 0.0354 ns |  0.92 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.3305 ns | 0.0270 ns | 0.0253 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.9764 ns | 0.0079 ns | 0.0074 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.6645 ns | 0.0060 ns | 0.0057 ns |  0.92 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  4.2735 ns | 0.0129 ns | 0.0114 ns |  1.08 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.6316 ns | 0.0153 ns | 0.0128 ns |  0.91 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.9408 ns | 0.0058 ns | 0.0051 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  5.2111 ns | 0.0089 ns | 0.0079 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  4.8347 ns | 0.0092 ns | 0.0082 ns |  0.93 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  5.3991 ns | 0.0159 ns | 0.0141 ns |  1.04 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  4.8733 ns | 0.0097 ns | 0.0081 ns |  0.94 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  4.8967 ns | 0.0073 ns | 0.0068 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.5429 ns | 0.0158 ns | 0.0147 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.7811 ns | 0.0394 ns | 0.0368 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  7.2193 ns | 0.0189 ns | 0.0148 ns |  0.53 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 14.0213 ns | 0.0268 ns | 0.0250 ns |  1.04 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 14.0782 ns | 0.0180 ns | 0.0168 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 24.5152 ns | 0.1017 ns | 0.0951 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 24.4961 ns | 0.0479 ns | 0.0425 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 13.3715 ns | 0.1288 ns | 0.1205 ns |  0.55 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 24.9511 ns | 0.0428 ns | 0.0379 ns |  1.02 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 24.7375 ns | 0.0636 ns | 0.0595 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9394 ns | 0.0071 ns | 0.0066 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7070 ns | 0.0109 ns | 0.0102 ns |  0.75 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.8686 ns | 0.0023 ns | 0.0019 ns |  0.92 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7631 ns | 0.0035 ns | 0.0031 ns |  0.81 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  1.2272 ns | 0.0081 ns | 0.0072 ns |  1.31 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4550 ns | 0.0122 ns | 0.0108 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.4442 ns | 0.0109 ns | 0.0102 ns |  0.99 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.5797 ns | 0.0421 ns | 0.0393 ns |  1.09 |    0.03 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.4469 ns | 0.0096 ns | 0.0090 ns |  0.99 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.4748 ns | 0.0106 ns | 0.0099 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.2848 ns | 0.0045 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.4112 ns | 0.0055 ns | 0.0046 ns |  1.06 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.1385 ns | 0.0098 ns | 0.0082 ns |  0.94 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  2.3532 ns | 0.0157 ns | 0.0147 ns |  1.03 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  2.3744 ns | 0.0162 ns | 0.0152 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 48.0314 ns | 0.1209 ns | 0.1072 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 42.4364 ns | 0.0769 ns | 0.0720 ns |  0.88 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  9.6680 ns | 0.0255 ns | 0.0239 ns |  0.20 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 47.6660 ns | 0.0588 ns | 0.0550 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 47.5919 ns | 0.0948 ns | 0.0841 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.8767 ns | 0.0070 ns | 0.0065 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.8948 ns | 0.0041 ns | 0.0038 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.8673 ns | 0.0146 ns | 0.0137 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.9104 ns | 0.0034 ns | 0.0028 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.9139 ns | 0.0072 ns | 0.0060 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  2.2569 ns | 0.0054 ns | 0.0050 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  2.6184 ns | 0.0093 ns | 0.0078 ns |  1.16 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.9601 ns | 0.0061 ns | 0.0054 ns |  0.87 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.3850 ns | 0.0173 ns | 0.0153 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.3700 ns | 0.0054 ns | 0.0050 ns |  1.05 |    0.00 |     - |     - |     - |         - |
