
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
             FromBool | .NET Core 2.0 |  1.1558 ns | 0.0032 ns | 0.0029 ns |  1.1560 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.8981 ns | 0.0090 ns | 0.0084 ns |  0.9031 ns |  0.78 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  1.2021 ns | 0.0371 ns | 0.0347 ns |  1.1847 ns |  1.04 |    0.03 |     - |     - |     - |         - |
             FromBool |        net461 |  1.4143 ns | 0.0556 ns | 0.1594 ns |  1.3046 ns |  1.23 |    0.16 |     - |     - |     - |         - |
             FromBool |        net472 |  0.8977 ns | 0.0021 ns | 0.0019 ns |  0.8978 ns |  0.78 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.4018 ns | 0.0038 ns | 0.0035 ns |  1.4024 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.2098 ns | 0.0037 ns | 0.0034 ns |  1.2100 ns |  0.86 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.2733 ns | 0.0204 ns | 0.0181 ns |  1.2740 ns |  0.91 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.0670 ns | 0.0305 ns | 0.0286 ns |  2.0608 ns |  1.47 |    0.02 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.0108 ns | 0.0248 ns | 0.0232 ns |  1.9979 ns |  1.43 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9471 ns | 0.0120 ns | 0.0113 ns |  0.9418 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.6928 ns | 0.0021 ns | 0.0020 ns |  0.6926 ns |  0.73 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.7032 ns | 0.0145 ns | 0.0129 ns |  0.6998 ns |  0.74 |    0.02 |     - |     - |     - |         - |
             FromChar |        net461 |  0.7493 ns | 0.0585 ns | 0.0548 ns |  0.7246 ns |  0.79 |    0.06 |     - |     - |     - |         - |
             FromChar |        net472 |  0.4881 ns | 0.0019 ns | 0.0017 ns |  0.4879 ns |  0.52 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.9435 ns | 0.0026 ns | 0.0024 ns |  0.9428 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.9273 ns | 0.0022 ns | 0.0021 ns |  0.9282 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.7974 ns | 0.0299 ns | 0.0280 ns |  0.7993 ns |  0.85 |    0.03 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.0355 ns | 0.0288 ns | 0.0256 ns |  1.0479 ns |  1.10 |    0.03 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  0.9106 ns | 0.0155 ns | 0.0145 ns |  0.9042 ns |  0.97 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.7161 ns | 0.0023 ns | 0.0022 ns |  0.7157 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.6115 ns | 0.0025 ns | 0.0023 ns |  0.6124 ns |  0.85 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.5604 ns | 0.0085 ns | 0.0075 ns |  0.5601 ns |  0.78 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.9529 ns | 0.0057 ns | 0.0053 ns |  0.9532 ns |  1.33 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.6552 ns | 0.0036 ns | 0.0032 ns |  0.6543 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.3742 ns | 0.0020 ns | 0.0019 ns |  1.3741 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.0554 ns | 0.0018 ns | 0.0017 ns |  1.0553 ns |  0.77 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.0299 ns | 0.0064 ns | 0.0057 ns |  1.0316 ns |  0.75 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.0186 ns | 0.0045 ns | 0.0038 ns |  2.0182 ns |  1.47 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.0292 ns | 0.0191 ns | 0.0179 ns |  2.0373 ns |  1.48 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.9481 ns | 0.0026 ns | 0.0024 ns |  0.9480 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.6823 ns | 0.0032 ns | 0.0029 ns |  0.6820 ns |  0.72 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.9679 ns | 0.0159 ns | 0.0141 ns |  0.9661 ns |  1.02 |    0.02 |     - |     - |     - |         - |
             FromByte |        net461 |  0.7580 ns | 0.0312 ns | 0.0292 ns |  0.7704 ns |  0.80 |    0.03 |     - |     - |     - |         - |
             FromByte |        net472 |  0.5852 ns | 0.0026 ns | 0.0023 ns |  0.5855 ns |  0.62 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.0646 ns | 0.0025 ns | 0.0020 ns |  1.0649 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.0741 ns | 0.0030 ns | 0.0028 ns |  1.0744 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.2330 ns | 0.0496 ns | 0.0464 ns |  1.2401 ns |  1.17 |    0.04 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  2.8693 ns | 0.0321 ns | 0.0300 ns |  2.8628 ns |  2.70 |    0.03 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9885 ns | 0.0047 ns | 0.0042 ns |  1.9880 ns |  1.87 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.7208 ns | 0.0025 ns | 0.0023 ns |  0.7207 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.6763 ns | 0.0020 ns | 0.0017 ns |  0.6756 ns |  0.94 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.9658 ns | 0.0265 ns | 0.0248 ns |  0.9671 ns |  1.34 |    0.04 |     - |     - |     - |         - |
            FromShort |        net461 |  0.9561 ns | 0.0086 ns | 0.0076 ns |  0.9549 ns |  1.33 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  0.6524 ns | 0.0130 ns | 0.0122 ns |  0.6587 ns |  0.91 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.1899 ns | 0.0029 ns | 0.0027 ns |  1.1892 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.2208 ns | 0.0020 ns | 0.0019 ns |  1.2204 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1982 ns | 0.0044 ns | 0.0039 ns |  1.1986 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.0509 ns | 0.0225 ns | 0.0187 ns |  2.0438 ns |  1.72 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.9671 ns | 0.0047 ns | 0.0044 ns |  1.9661 ns |  1.65 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.9395 ns | 0.0016 ns | 0.0015 ns |  0.9397 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.6590 ns | 0.0029 ns | 0.0027 ns |  0.6583 ns |  0.70 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.7254 ns | 0.0068 ns | 0.0061 ns |  0.7258 ns |  0.77 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.7016 ns | 0.0098 ns | 0.0076 ns |  0.6999 ns |  0.75 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.6361 ns | 0.0031 ns | 0.0029 ns |  0.6361 ns |  0.68 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.1156 ns | 0.0029 ns | 0.0027 ns |  1.1156 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.1945 ns | 0.0030 ns | 0.0024 ns |  1.1947 ns |  1.07 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.2468 ns | 0.0336 ns | 0.0315 ns |  1.2476 ns |  1.12 |    0.03 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.0228 ns | 0.0043 ns | 0.0038 ns |  2.0228 ns |  1.81 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.0074 ns | 0.0253 ns | 0.0224 ns |  2.0184 ns |  1.80 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.8277 ns | 0.0025 ns | 0.0023 ns |  0.8279 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.6932 ns | 0.0028 ns | 0.0027 ns |  0.6945 ns |  0.84 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.9319 ns | 0.0067 ns | 0.0053 ns |  0.9311 ns |  1.13 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  0.7391 ns | 0.0028 ns | 0.0025 ns |  0.7387 ns |  0.89 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  0.6661 ns | 0.0029 ns | 0.0026 ns |  0.6650 ns |  0.80 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.5273 ns | 0.0030 ns | 0.0027 ns |  1.5282 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.1521 ns | 0.0022 ns | 0.0021 ns |  1.1522 ns |  0.75 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.1494 ns | 0.0087 ns | 0.0073 ns |  1.1475 ns |  0.75 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.0307 ns | 0.0075 ns | 0.0070 ns |  2.0285 ns |  1.33 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.9875 ns | 0.0234 ns | 0.0196 ns |  1.9799 ns |  1.30 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.9474 ns | 0.0030 ns | 0.0027 ns |  0.9480 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.7290 ns | 0.0032 ns | 0.0028 ns |  0.7279 ns |  0.77 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.8628 ns | 0.0066 ns | 0.0061 ns |  0.8619 ns |  0.91 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.1010 ns | 0.0223 ns | 0.0208 ns |  1.0888 ns |  1.16 |    0.02 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.7709 ns | 0.0016 ns | 0.0013 ns |  0.7705 ns |  0.81 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.1365 ns | 0.0025 ns | 0.0023 ns |  1.1362 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.2635 ns | 0.0034 ns | 0.0030 ns |  1.2640 ns |  1.11 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.2056 ns | 0.0067 ns | 0.0063 ns |  1.2061 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.0575 ns | 0.0032 ns | 0.0029 ns |  2.0567 ns |  1.81 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.0909 ns | 0.0333 ns | 0.0311 ns |  2.1079 ns |  1.84 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  0.7198 ns | 0.0022 ns | 0.0020 ns |  0.7199 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  0.7218 ns | 0.0025 ns | 0.0023 ns |  0.7214 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.8549 ns | 0.0059 ns | 0.0049 ns |  0.8531 ns |  1.19 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  0.7380 ns | 0.0050 ns | 0.0047 ns |  0.7369 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  0.7486 ns | 0.0009 ns | 0.0007 ns |  0.7484 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.6763 ns | 0.0027 ns | 0.0022 ns |  1.6772 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.6789 ns | 0.0028 ns | 0.0026 ns |  1.6791 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.6594 ns | 0.0128 ns | 0.0119 ns |  1.6634 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.3131 ns | 0.0025 ns | 0.0024 ns |  2.3129 ns |  1.38 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.3727 ns | 0.0033 ns | 0.0027 ns |  2.3722 ns |  1.42 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.1742 ns | 0.0033 ns | 0.0028 ns |  1.1737 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  0.9137 ns | 0.0030 ns | 0.0028 ns |  0.9130 ns |  0.78 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.0040 ns | 0.0234 ns | 0.0219 ns |  0.9997 ns |  0.86 |    0.02 |     - |     - |     - |         - |
            FromULong |        net461 |  1.2118 ns | 0.0032 ns | 0.0029 ns |  1.2118 ns |  1.03 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.1764 ns | 0.0009 ns | 0.0008 ns |  1.1768 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.9311 ns | 0.0031 ns | 0.0029 ns |  1.9318 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  2.1064 ns | 0.0038 ns | 0.0035 ns |  2.1060 ns |  1.09 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  2.6176 ns | 0.0682 ns | 0.0638 ns |  2.6536 ns |  1.36 |    0.03 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.5307 ns | 0.0045 ns | 0.0042 ns |  2.5317 ns |  1.31 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.6159 ns | 0.0317 ns | 0.0281 ns |  2.6020 ns |  1.35 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  0.6884 ns | 0.0018 ns | 0.0017 ns |  0.6884 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  0.5905 ns | 0.0026 ns | 0.0023 ns |  0.5905 ns |  0.86 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  0.6746 ns | 0.0086 ns | 0.0076 ns |  0.6746 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  0.7231 ns | 0.0140 ns | 0.0131 ns |  0.7300 ns |  1.05 |    0.02 |     - |     - |     - |         - |
            FromFloat |        net472 |  0.7435 ns | 0.0323 ns | 0.0286 ns |  0.7379 ns |  1.08 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  0.7518 ns | 0.0016 ns | 0.0014 ns |  0.7518 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  0.5364 ns | 0.0017 ns | 0.0016 ns |  0.5364 ns |  0.71 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  0.6458 ns | 0.0077 ns | 0.0072 ns |  0.6476 ns |  0.86 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  0.9558 ns | 0.0021 ns | 0.0018 ns |  0.9559 ns |  1.27 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  0.9792 ns | 0.0063 ns | 0.0059 ns |  0.9786 ns |  1.30 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  0.9166 ns | 0.0033 ns | 0.0030 ns |  0.9169 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  0.6903 ns | 0.0023 ns | 0.0020 ns |  0.6908 ns |  0.75 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  0.7570 ns | 0.0246 ns | 0.0230 ns |  0.7602 ns |  0.83 |    0.03 |     - |     - |     - |         - |
           FromDouble |        net461 |  0.9360 ns | 0.0035 ns | 0.0031 ns |  0.9363 ns |  1.02 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  0.9529 ns | 0.0086 ns | 0.0072 ns |  0.9533 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.7220 ns | 0.0169 ns | 0.0158 ns |  1.7290 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.7119 ns | 0.0222 ns | 0.0196 ns |  1.7022 ns |  0.99 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.7211 ns | 0.0067 ns | 0.0062 ns |  1.7215 ns |  1.00 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.3815 ns | 0.0284 ns | 0.0266 ns |  2.3887 ns |  1.38 |    0.02 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.3690 ns | 0.0157 ns | 0.0147 ns |  2.3728 ns |  1.38 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 10.0599 ns | 0.0151 ns | 0.0141 ns | 10.0616 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 11.2852 ns | 0.3038 ns | 0.4454 ns | 11.0997 ns |  1.14 |    0.06 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.5195 ns | 0.0222 ns | 0.0197 ns |  5.5254 ns |  0.55 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 11.0267 ns | 0.0084 ns | 0.0079 ns | 11.0252 ns |  1.10 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 11.2081 ns | 0.1469 ns | 0.1374 ns | 11.2793 ns |  1.11 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 25.3946 ns | 0.0218 ns | 0.0204 ns | 25.3915 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 25.4959 ns | 0.0793 ns | 0.0742 ns | 25.5033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 18.9902 ns | 0.1579 ns | 0.1477 ns | 19.0240 ns |  0.75 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 30.6657 ns | 0.0098 ns | 0.0082 ns | 30.6637 ns |  1.21 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 25.8863 ns | 0.1166 ns | 0.1034 ns | 25.9408 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9472 ns | 0.0114 ns | 0.0107 ns |  0.9529 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7153 ns | 0.0048 ns | 0.0045 ns |  0.7143 ns |  0.76 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7028 ns | 0.0094 ns | 0.0083 ns |  0.7002 ns |  0.74 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.9599 ns | 0.0028 ns | 0.0022 ns |  0.9601 ns |  1.01 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.9391 ns | 0.0192 ns | 0.0179 ns |  0.9446 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4466 ns | 0.0032 ns | 0.0030 ns |  1.4465 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.7854 ns | 0.0399 ns | 0.0373 ns |  1.7660 ns |  1.23 |    0.03 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4814 ns | 0.0263 ns | 0.0246 ns |  1.4884 ns |  1.02 |    0.02 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6377 ns | 0.0064 ns | 0.0060 ns |  1.6361 ns |  1.13 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.7015 ns | 0.0156 ns | 0.0131 ns |  1.6968 ns |  1.18 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 10.2112 ns | 0.0103 ns | 0.0092 ns | 10.2152 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 14.6752 ns | 0.1355 ns | 0.1201 ns | 14.6796 ns |  1.44 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 15.1855 ns | 0.0413 ns | 0.0386 ns | 15.1736 ns |  1.49 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 | 15.1244 ns | 0.1561 ns | 0.1460 ns | 15.1946 ns |  1.48 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 | 13.9527 ns | 0.0685 ns | 0.0607 ns | 13.9758 ns |  1.37 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 60.3018 ns | 0.1278 ns | 0.1195 ns | 60.3198 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 60.8711 ns | 0.3276 ns | 0.3065 ns | 60.7720 ns |  1.01 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 48.5932 ns | 0.7532 ns | 0.6677 ns | 48.3755 ns |  0.81 |    0.01 |     - |     - |     - |         - |
           FromString |        net461 | 59.3408 ns | 0.0959 ns | 0.0850 ns | 59.3456 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 62.7218 ns | 1.0267 ns | 0.9603 ns | 62.4268 ns |  1.04 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.7093 ns | 0.0032 ns | 0.0030 ns |  0.7092 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.7226 ns | 0.0348 ns | 0.0308 ns |  0.7151 ns |  1.02 |    0.04 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.8547 ns | 0.0097 ns | 0.0081 ns |  0.8533 ns |  1.21 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.9513 ns | 0.0194 ns | 0.0162 ns |  0.9561 ns |  1.34 |    0.02 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.9335 ns | 0.0080 ns | 0.0067 ns |  0.9357 ns |  1.32 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.4112 ns | 0.0032 ns | 0.0030 ns |  1.4119 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.2146 ns | 0.0176 ns | 0.0138 ns |  1.2144 ns |  0.86 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.1557 ns | 0.0504 ns | 0.0472 ns |  1.1661 ns |  0.82 |    0.03 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.0221 ns | 0.0183 ns | 0.0171 ns |  2.0278 ns |  1.43 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.2415 ns | 0.0185 ns | 0.0164 ns |  2.2332 ns |  1.59 |    0.01 |     - |     - |     - |         - |
