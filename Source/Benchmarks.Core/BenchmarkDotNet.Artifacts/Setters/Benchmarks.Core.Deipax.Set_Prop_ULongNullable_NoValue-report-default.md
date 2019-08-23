
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EESCLK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-QSSVGP : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EOYUJY : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-ETYLEW : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-VJGCOH : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  0.9168 ns | 0.0109 ns | 0.0097 ns |  0.9210 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6627 ns | 0.0013 ns | 0.0012 ns |  0.6630 ns |  0.72 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.7450 ns | 0.0018 ns | 0.0017 ns |  0.7445 ns |  0.81 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6601 ns | 0.0023 ns | 0.0022 ns |  0.6607 ns |  0.72 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9212 ns | 0.0021 ns | 0.0018 ns |  0.9208 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1477 ns | 0.0038 ns | 0.0029 ns |  1.1476 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1211 ns | 0.0041 ns | 0.0039 ns |  1.1208 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1880 ns | 0.0090 ns | 0.0084 ns |  1.1874 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.6643 ns | 0.0040 ns | 0.0037 ns |  2.6638 ns |  2.32 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.9246 ns | 0.0049 ns | 0.0041 ns |  1.9235 ns |  1.68 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9118 ns | 0.0018 ns | 0.0017 ns |  0.9118 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.8648 ns | 0.0015 ns | 0.0014 ns |  0.8648 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.5713 ns | 0.0023 ns | 0.0020 ns |  0.5716 ns |  0.63 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  0.6315 ns | 0.0018 ns | 0.0017 ns |  0.6316 ns |  0.69 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.7372 ns | 0.0068 ns | 0.0064 ns |  0.7343 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.1579 ns | 0.0025 ns | 0.0023 ns |  1.1578 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.0467 ns | 0.0032 ns | 0.0027 ns |  1.0462 ns |  0.90 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.0739 ns | 0.0014 ns | 0.0013 ns |  1.0738 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.9242 ns | 0.0019 ns | 0.0017 ns |  1.9241 ns |  1.66 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.9125 ns | 0.0034 ns | 0.0031 ns |  1.9127 ns |  1.65 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.3182 ns | 0.0116 ns | 0.0109 ns |  1.3221 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.3551 ns | 0.0029 ns | 0.0027 ns |  1.3556 ns |  1.03 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6359 ns | 0.0087 ns | 0.0082 ns |  0.6319 ns |  0.48 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.7409 ns | 0.0033 ns | 0.0030 ns |  1.7414 ns |  1.32 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.7661 ns | 0.0047 ns | 0.0041 ns |  1.7661 ns |  1.34 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.7556 ns | 0.0035 ns | 0.0033 ns |  1.7559 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  2.0097 ns | 0.0029 ns | 0.0027 ns |  2.0098 ns |  1.14 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.1567 ns | 0.0032 ns | 0.0028 ns |  1.1561 ns |  0.66 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.1514 ns | 0.0047 ns | 0.0044 ns |  2.1518 ns |  1.23 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.1533 ns | 0.0169 ns | 0.0158 ns |  2.1641 ns |  1.23 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.9136 ns | 0.0024 ns | 0.0020 ns |  0.9135 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.5555 ns | 0.0025 ns | 0.0023 ns |  0.5562 ns |  0.61 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.7191 ns | 0.0033 ns | 0.0025 ns |  0.7189 ns |  0.79 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  0.6892 ns | 0.0101 ns | 0.0095 ns |  0.6940 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.9343 ns | 0.0015 ns | 0.0014 ns |  0.9340 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.1472 ns | 0.0073 ns | 0.0068 ns |  1.1483 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9006 ns | 0.0026 ns | 0.0023 ns |  0.9003 ns |  0.79 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9532 ns | 0.0074 ns | 0.0069 ns |  0.9503 ns |  0.83 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9019 ns | 0.0022 ns | 0.0021 ns |  1.9020 ns |  1.66 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9376 ns | 0.0141 ns | 0.0132 ns |  1.9302 ns |  1.69 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.3707 ns | 0.0019 ns | 0.0018 ns |  1.3704 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  5.7619 ns | 0.0044 ns | 0.0041 ns |  5.7622 ns |  4.20 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.7140 ns | 0.0068 ns | 0.0063 ns |  0.7124 ns |  0.52 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.7399 ns | 0.0017 ns | 0.0016 ns |  1.7403 ns |  1.27 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  1.7656 ns | 0.0017 ns | 0.0014 ns |  1.7662 ns |  1.29 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.8305 ns | 0.0020 ns | 0.0017 ns |  1.8303 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.7131 ns | 0.0032 ns | 0.0030 ns |  1.7131 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.0787 ns | 0.0026 ns | 0.0023 ns |  1.0789 ns |  0.59 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.9084 ns | 0.0193 ns | 0.0181 ns |  1.9224 ns |  1.04 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.9129 ns | 0.0036 ns | 0.0030 ns |  1.9132 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.9131 ns | 0.0081 ns | 0.0076 ns |  0.9173 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.6300 ns | 0.0020 ns | 0.0018 ns |  0.6305 ns |  0.69 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.5770 ns | 0.0074 ns | 0.0069 ns |  0.5741 ns |  0.63 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.6345 ns | 0.0023 ns | 0.0021 ns |  0.6344 ns |  0.69 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.7335 ns | 0.0043 ns | 0.0036 ns |  0.7341 ns |  0.80 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.1541 ns | 0.0022 ns | 0.0020 ns |  1.1544 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.0433 ns | 0.0172 ns | 0.0152 ns |  1.0436 ns |  0.90 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.0753 ns | 0.0031 ns | 0.0029 ns |  1.0755 ns |  0.93 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.0247 ns | 0.0026 ns | 0.0024 ns |  2.0247 ns |  1.75 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.9096 ns | 0.0017 ns | 0.0016 ns |  1.9097 ns |  1.65 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.4461 ns | 0.0027 ns | 0.0025 ns |  1.4461 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.3877 ns | 0.0031 ns | 0.0029 ns |  1.3876 ns |  0.96 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.9564 ns | 0.0021 ns | 0.0020 ns |  0.9568 ns |  0.66 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7379 ns | 0.0050 ns | 0.0042 ns |  1.7376 ns |  1.20 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7647 ns | 0.0073 ns | 0.0068 ns |  1.7622 ns |  1.22 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.9393 ns | 0.0097 ns | 0.0091 ns |  1.9406 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.8809 ns | 0.0112 ns | 0.0105 ns |  1.8770 ns |  0.97 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.0801 ns | 0.0030 ns | 0.0023 ns |  1.0804 ns |  0.56 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.8997 ns | 0.0017 ns | 0.0016 ns |  1.8991 ns |  0.98 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.9192 ns | 0.0152 ns | 0.0142 ns |  1.9108 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.9164 ns | 0.0015 ns | 0.0014 ns |  0.9166 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.7231 ns | 0.0124 ns | 0.0110 ns |  0.7195 ns |  0.79 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.9480 ns | 0.0033 ns | 0.0031 ns |  0.9479 ns |  1.03 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.7202 ns | 0.0020 ns | 0.0019 ns |  0.7200 ns |  0.79 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.6547 ns | 0.0030 ns | 0.0028 ns |  0.6550 ns |  0.71 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.0026 ns | 0.0023 ns | 0.0019 ns |  1.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.1680 ns | 0.0028 ns | 0.0026 ns |  1.1676 ns |  1.17 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.1955 ns | 0.0036 ns | 0.0032 ns |  1.1951 ns |  1.19 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.9119 ns | 0.0027 ns | 0.0024 ns |  1.9116 ns |  1.91 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.8856 ns | 0.0033 ns | 0.0030 ns |  1.8863 ns |  1.88 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.4251 ns | 0.0138 ns | 0.0129 ns |  1.4166 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.3754 ns | 0.0040 ns | 0.0033 ns |  1.3752 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.7585 ns | 0.0120 ns | 0.0106 ns |  0.7634 ns |  0.53 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  1.7633 ns | 0.0052 ns | 0.0048 ns |  1.7643 ns |  1.24 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.7064 ns | 0.0023 ns | 0.0021 ns |  1.7061 ns |  1.20 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.9740 ns | 0.0027 ns | 0.0025 ns |  1.9743 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.9607 ns | 0.0024 ns | 0.0022 ns |  1.9601 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.4740 ns | 0.0026 ns | 0.0023 ns |  1.4739 ns |  0.75 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  1.9759 ns | 0.0186 ns | 0.0174 ns |  1.9775 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  3.0888 ns | 0.0874 ns | 0.1484 ns |  3.1395 ns |  1.58 |    0.08 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  0.9225 ns | 0.0047 ns | 0.0041 ns |  0.9233 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  0.7031 ns | 0.0026 ns | 0.0022 ns |  0.7035 ns |  0.76 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.7432 ns | 0.0079 ns | 0.0074 ns |  0.7406 ns |  0.81 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  0.6994 ns | 0.0013 ns | 0.0012 ns |  0.6995 ns |  0.76 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  0.6530 ns | 0.0014 ns | 0.0011 ns |  0.6534 ns |  0.71 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.3544 ns | 0.0526 ns | 0.0921 ns |  1.3496 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.1887 ns | 0.0134 ns | 0.0125 ns |  1.1830 ns |  0.87 |    0.06 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.1457 ns | 0.0026 ns | 0.0024 ns |  1.1458 ns |  0.84 |    0.06 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  1.4356 ns | 0.0034 ns | 0.0032 ns |  1.4359 ns |  1.05 |    0.07 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  1.3574 ns | 0.0039 ns | 0.0032 ns |  1.3568 ns |  1.00 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.2118 ns | 0.0080 ns | 0.0075 ns |  3.2091 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  2.5571 ns | 0.0043 ns | 0.0040 ns |  2.5582 ns |  0.80 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  2.1651 ns | 0.0023 ns | 0.0020 ns |  2.1657 ns |  0.67 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.3677 ns | 0.0045 ns | 0.0042 ns |  3.3665 ns |  1.05 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.3312 ns | 0.0044 ns | 0.0041 ns |  3.3311 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.8737 ns | 0.0034 ns | 0.0032 ns |  1.8739 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.8427 ns | 0.0027 ns | 0.0022 ns |  1.8422 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.7756 ns | 0.0025 ns | 0.0022 ns |  1.7756 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.9384 ns | 0.0035 ns | 0.0029 ns |  1.9382 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.8780 ns | 0.0020 ns | 0.0018 ns |  1.8782 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.1221 ns | 0.0054 ns | 0.0050 ns |  3.1232 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  2.1059 ns | 0.0093 ns | 0.0087 ns |  2.1081 ns |  0.67 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  1.9305 ns | 0.0025 ns | 0.0022 ns |  1.9301 ns |  0.62 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.2856 ns | 0.0040 ns | 0.0035 ns |  3.2852 ns |  1.05 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.2506 ns | 0.0046 ns | 0.0039 ns |  3.2499 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.9045 ns | 0.0130 ns | 0.0122 ns |  1.8988 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.8989 ns | 0.0022 ns | 0.0021 ns |  1.8987 ns |  1.00 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.9849 ns | 0.0074 ns | 0.0069 ns |  1.9865 ns |  1.04 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.7198 ns | 0.0048 ns | 0.0045 ns |  2.7195 ns |  1.43 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.1438 ns | 0.0031 ns | 0.0029 ns |  2.1448 ns |  1.13 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 12.7361 ns | 0.0141 ns | 0.0131 ns | 12.7395 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.1230 ns | 0.0119 ns | 0.0111 ns | 13.1209 ns |  1.03 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.7072 ns | 0.0036 ns | 0.0032 ns |  5.7076 ns |  0.45 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.3040 ns | 0.0108 ns | 0.0090 ns | 13.3057 ns |  1.04 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.3032 ns | 0.0126 ns | 0.0118 ns | 13.3061 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.3300 ns | 0.0121 ns | 0.0113 ns |  8.3304 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  8.7319 ns | 0.0527 ns | 0.0493 ns |  8.7051 ns |  1.05 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  2.6058 ns | 0.0157 ns | 0.0139 ns |  2.5996 ns |  0.31 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  9.2383 ns | 0.0105 ns | 0.0098 ns |  9.2373 ns |  1.11 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  9.3182 ns | 0.0227 ns | 0.0212 ns |  9.3269 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9167 ns | 0.0024 ns | 0.0020 ns |  0.9168 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7112 ns | 0.0010 ns | 0.0008 ns |  0.7114 ns |  0.78 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  1.4759 ns | 0.0031 ns | 0.0029 ns |  1.4756 ns |  1.61 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7225 ns | 0.0021 ns | 0.0020 ns |  0.7231 ns |  0.79 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.6636 ns | 0.0026 ns | 0.0025 ns |  0.6624 ns |  0.72 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4501 ns | 0.0031 ns | 0.0029 ns |  1.4504 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6432 ns | 0.0027 ns | 0.0023 ns |  1.6427 ns |  1.13 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4755 ns | 0.0027 ns | 0.0025 ns |  1.4758 ns |  1.02 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6618 ns | 0.0026 ns | 0.0024 ns |  1.6622 ns |  1.15 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6242 ns | 0.0024 ns | 0.0022 ns |  1.6241 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  3.1021 ns | 0.0081 ns | 0.0076 ns |  3.1032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.8811 ns | 0.0209 ns | 0.0196 ns |  2.8923 ns |  0.93 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.7510 ns | 0.0152 ns | 0.0142 ns |  2.7448 ns |  0.89 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  3.0235 ns | 0.0041 ns | 0.0038 ns |  3.0232 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  2.9895 ns | 0.0042 ns | 0.0039 ns |  2.9893 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  1.8169 ns | 0.0023 ns | 0.0021 ns |  1.8169 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  1.8894 ns | 0.0026 ns | 0.0025 ns |  1.8894 ns |  1.04 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.9062 ns | 0.0031 ns | 0.0029 ns |  1.9062 ns |  1.05 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 |  1.8111 ns | 0.0018 ns | 0.0016 ns |  1.8118 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 |  1.7757 ns | 0.0019 ns | 0.0018 ns |  1.7761 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.4666 ns | 0.0035 ns | 0.0033 ns |  1.4668 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.4141 ns | 0.0032 ns | 0.0029 ns |  1.4143 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.9604 ns | 0.0020 ns | 0.0019 ns |  0.9604 ns |  0.65 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.7674 ns | 0.0027 ns | 0.0024 ns |  1.7674 ns |  1.20 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.7432 ns | 0.0096 ns | 0.0085 ns |  1.7459 ns |  1.19 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.9422 ns | 0.0022 ns | 0.0021 ns |  1.9425 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.9362 ns | 0.0129 ns | 0.0114 ns |  1.9394 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.0904 ns | 0.0105 ns | 0.0098 ns |  1.0858 ns |  0.56 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.9142 ns | 0.0026 ns | 0.0024 ns |  1.9138 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.8821 ns | 0.0024 ns | 0.0022 ns |  1.8827 ns |  0.97 |    0.00 |     - |     - |     - |         - |
