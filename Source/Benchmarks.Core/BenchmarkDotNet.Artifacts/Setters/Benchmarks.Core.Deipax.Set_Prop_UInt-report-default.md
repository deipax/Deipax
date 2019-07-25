
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
             FromBool | .NET Core 2.0 |  0.9206 ns | 0.0026 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9210 ns | 0.0042 ns | 0.0040 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  1.1593 ns | 0.0045 ns | 0.0042 ns |  1.26 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  1.1621 ns | 0.0209 ns | 0.0196 ns |  1.26 |    0.02 |     - |     - |     - |         - |
             FromBool |        net472 |  0.8952 ns | 0.0049 ns | 0.0046 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.3893 ns | 0.0047 ns | 0.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1577 ns | 0.0043 ns | 0.0038 ns |  0.83 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.4228 ns | 0.0440 ns | 0.0390 ns |  1.02 |    0.03 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.6322 ns | 0.0056 ns | 0.0050 ns |  1.17 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.7891 ns | 0.0084 ns | 0.0079 ns |  1.29 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.6906 ns | 0.0034 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.4603 ns | 0.0031 ns | 0.0029 ns |  0.67 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.6954 ns | 0.0119 ns | 0.0105 ns |  1.01 |    0.02 |     - |     - |     - |         - |
             FromChar |        net461 |  0.4384 ns | 0.0021 ns | 0.0019 ns |  0.63 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  1.0025 ns | 0.0044 ns | 0.0039 ns |  1.45 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.1540 ns | 0.0037 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.9251 ns | 0.0030 ns | 0.0028 ns |  0.80 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1718 ns | 0.0141 ns | 0.0125 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.6093 ns | 0.0049 ns | 0.0041 ns |  1.39 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.6199 ns | 0.0053 ns | 0.0050 ns |  1.40 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.1028 ns | 0.0029 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.1238 ns | 0.0061 ns | 0.0054 ns |  1.02 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.9251 ns | 0.0072 ns | 0.0060 ns |  0.84 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.5452 ns | 0.0178 ns | 0.0158 ns |  1.40 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.5183 ns | 0.0069 ns | 0.0065 ns |  1.38 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.4696 ns | 0.0043 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.4973 ns | 0.0104 ns | 0.0097 ns |  1.02 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.1627 ns | 0.0081 ns | 0.0075 ns |  0.79 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.0558 ns | 0.0133 ns | 0.0118 ns |  1.40 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.0881 ns | 0.0608 ns | 0.0569 ns |  1.42 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.6896 ns | 0.0037 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.4541 ns | 0.0018 ns | 0.0016 ns |  0.66 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.6837 ns | 0.0079 ns | 0.0070 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.4313 ns | 0.0023 ns | 0.0019 ns |  0.63 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.4486 ns | 0.0238 ns | 0.0211 ns |  0.65 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.1658 ns | 0.0072 ns | 0.0061 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9264 ns | 0.0024 ns | 0.0022 ns |  0.79 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.1547 ns | 0.0051 ns | 0.0047 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.5902 ns | 0.0037 ns | 0.0032 ns |  1.36 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.6149 ns | 0.0141 ns | 0.0125 ns |  1.38 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.1075 ns | 0.0032 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.1174 ns | 0.0031 ns | 0.0025 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.8928 ns | 0.0051 ns | 0.0046 ns |  0.81 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.6217 ns | 0.0145 ns | 0.0135 ns |  1.46 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  1.6095 ns | 0.0104 ns | 0.0092 ns |  1.45 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.5886 ns | 0.0034 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.5804 ns | 0.0057 ns | 0.0054 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1556 ns | 0.0045 ns | 0.0040 ns |  0.73 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.3050 ns | 0.0052 ns | 0.0048 ns |  1.45 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.3144 ns | 0.0133 ns | 0.0125 ns |  1.46 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.7266 ns | 0.0030 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.4522 ns | 0.0015 ns | 0.0014 ns |  0.62 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6925 ns | 0.0063 ns | 0.0059 ns |  0.95 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.4391 ns | 0.0107 ns | 0.0100 ns |  0.60 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.4366 ns | 0.0034 ns | 0.0030 ns |  0.60 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.4013 ns | 0.0044 ns | 0.0041 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  0.9355 ns | 0.0052 ns | 0.0049 ns |  0.67 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1741 ns | 0.0170 ns | 0.0142 ns |  0.84 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.6110 ns | 0.0036 ns | 0.0034 ns |  1.15 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.7910 ns | 0.0103 ns | 0.0096 ns |  1.28 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.2319 ns | 0.0061 ns | 0.0057 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.2834 ns | 0.0032 ns | 0.0029 ns |  1.04 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.9193 ns | 0.0064 ns | 0.0060 ns |  0.75 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  1.5876 ns | 0.0027 ns | 0.0024 ns |  1.29 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  1.6000 ns | 0.0110 ns | 0.0103 ns |  1.30 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.7374 ns | 0.0033 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.6483 ns | 0.0047 ns | 0.0039 ns |  0.95 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.1595 ns | 0.0114 ns | 0.0101 ns |  0.67 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.0578 ns | 0.0050 ns | 0.0047 ns |  1.18 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.2026 ns | 0.0173 ns | 0.0161 ns |  1.27 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.7261 ns | 0.0056 ns | 0.0047 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.4589 ns | 0.0098 ns | 0.0092 ns |  0.63 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.4956 ns | 0.0070 ns | 0.0065 ns |  0.68 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.4432 ns | 0.0037 ns | 0.0029 ns |  0.61 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.4471 ns | 0.0075 ns | 0.0067 ns |  0.62 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.1919 ns | 0.0047 ns | 0.0044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  0.9362 ns | 0.0536 ns | 0.0475 ns |  0.79 |    0.04 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  0.9146 ns | 0.0047 ns | 0.0039 ns |  0.77 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.3836 ns | 0.0042 ns | 0.0037 ns |  1.16 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.3904 ns | 0.0060 ns | 0.0056 ns |  1.17 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.8825 ns | 0.0097 ns | 0.0091 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.6122 ns | 0.0526 ns | 0.0466 ns |  0.86 |    0.02 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.8660 ns | 0.0380 ns | 0.0356 ns |  0.99 |    0.02 |     - |     - |     - |         - |
             FromLong |        net461 |  1.6084 ns | 0.0046 ns | 0.0043 ns |  0.85 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  1.6110 ns | 0.0079 ns | 0.0070 ns |  0.86 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  3.2865 ns | 0.0064 ns | 0.0054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  2.7010 ns | 0.0129 ns | 0.0115 ns |  0.82 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  3.1945 ns | 0.0243 ns | 0.0228 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.7176 ns | 0.0083 ns | 0.0078 ns |  0.83 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.7549 ns | 0.0144 ns | 0.0135 ns |  0.84 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.2677 ns | 0.0037 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.1420 ns | 0.0130 ns | 0.0115 ns |  0.90 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.6542 ns | 0.0023 ns | 0.0021 ns |  0.52 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.5148 ns | 0.0029 ns | 0.0025 ns |  1.20 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.5559 ns | 0.0043 ns | 0.0039 ns |  1.23 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.9646 ns | 0.0045 ns | 0.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.9966 ns | 0.0087 ns | 0.0081 ns |  1.02 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.7481 ns | 0.0101 ns | 0.0094 ns |  0.89 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  3.1199 ns | 0.0287 ns | 0.0239 ns |  1.59 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  3.0527 ns | 0.0284 ns | 0.0266 ns |  1.55 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.5989 ns | 0.0067 ns | 0.0063 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.5437 ns | 0.0280 ns | 0.0262 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  3.4096 ns | 0.0077 ns | 0.0068 ns |  0.95 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.5459 ns | 0.0183 ns | 0.0162 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.5147 ns | 0.0222 ns | 0.0185 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  3.0588 ns | 0.0078 ns | 0.0070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  3.0834 ns | 0.0115 ns | 0.0102 ns |  1.01 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  3.2383 ns | 0.0233 ns | 0.0207 ns |  1.06 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  3.4280 ns | 0.0059 ns | 0.0056 ns |  1.12 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  3.4509 ns | 0.0081 ns | 0.0067 ns |  1.13 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  2.4000 ns | 0.0074 ns | 0.0066 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  2.6151 ns | 0.0728 ns | 0.0646 ns |  1.09 |    0.03 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  2.8367 ns | 0.0076 ns | 0.0067 ns |  1.18 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  2.5506 ns | 0.0045 ns | 0.0040 ns |  1.06 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  2.5718 ns | 0.0170 ns | 0.0159 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  3.4525 ns | 0.0070 ns | 0.0062 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  3.6180 ns | 0.0527 ns | 0.0468 ns |  1.05 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  3.9210 ns | 0.0083 ns | 0.0069 ns |  1.14 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  3.8083 ns | 0.0247 ns | 0.0231 ns |  1.10 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  3.8385 ns | 0.0255 ns | 0.0226 ns |  1.11 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 12.6565 ns | 0.0246 ns | 0.0218 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.2720 ns | 0.1841 ns | 0.1632 ns |  1.05 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.8180 ns | 0.0075 ns | 0.0066 ns |  0.46 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.1123 ns | 0.0140 ns | 0.0131 ns |  1.04 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.1565 ns | 0.0741 ns | 0.0693 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 24.5316 ns | 0.0352 ns | 0.0329 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 23.7387 ns | 0.0547 ns | 0.0457 ns |  0.97 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 12.6517 ns | 0.1139 ns | 0.1065 ns |  0.52 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 23.7595 ns | 0.0383 ns | 0.0358 ns |  0.97 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 23.7282 ns | 0.0536 ns | 0.0501 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.7303 ns | 0.0045 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.4507 ns | 0.0184 ns | 0.0172 ns |  0.62 |    0.02 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.5061 ns | 0.0147 ns | 0.0130 ns |  0.69 |    0.02 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.4736 ns | 0.0077 ns | 0.0072 ns |  0.65 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.4542 ns | 0.0110 ns | 0.0103 ns |  0.62 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.3879 ns | 0.0033 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.4536 ns | 0.0258 ns | 0.0229 ns |  1.05 |    0.02 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4772 ns | 0.0042 ns | 0.0037 ns |  1.06 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.4280 ns | 0.0044 ns | 0.0041 ns |  1.03 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.4303 ns | 0.0113 ns | 0.0095 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.2797 ns | 0.0155 ns | 0.0145 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.2511 ns | 0.0166 ns | 0.0147 ns |  0.99 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.1056 ns | 0.0028 ns | 0.0023 ns |  0.92 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  2.6545 ns | 0.0076 ns | 0.0067 ns |  1.16 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  2.2529 ns | 0.0093 ns | 0.0087 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 46.9702 ns | 0.0791 ns | 0.0701 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 39.9952 ns | 0.8160 ns | 0.8379 ns |  0.85 |    0.02 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 11.2962 ns | 0.0303 ns | 0.0284 ns |  0.24 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 46.2136 ns | 0.0665 ns | 0.0622 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 46.2364 ns | 0.1291 ns | 0.1208 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.2328 ns | 0.0029 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.2827 ns | 0.0101 ns | 0.0094 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.9050 ns | 0.0041 ns | 0.0038 ns |  0.73 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.6884 ns | 0.0041 ns | 0.0036 ns |  1.37 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.6060 ns | 0.0066 ns | 0.0062 ns |  1.30 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.7395 ns | 0.0057 ns | 0.0048 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.6755 ns | 0.0144 ns | 0.0128 ns |  0.96 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.1410 ns | 0.0060 ns | 0.0053 ns |  0.66 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.0709 ns | 0.0036 ns | 0.0032 ns |  1.19 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.0886 ns | 0.0172 ns | 0.0161 ns |  1.20 |    0.01 |     - |     - |     - |         - |
