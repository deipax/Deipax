
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-JBIYRV : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-GQVRNQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-BKGSYN : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-NLOXWC : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-AAMQWS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 | 11.6077 ns | 0.0147 ns | 0.0122 ns | 11.6110 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 | 11.6160 ns | 0.0097 ns | 0.0091 ns | 11.6151 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  6.3902 ns | 0.1301 ns | 0.1217 ns |  6.3371 ns |  0.55 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 | 11.6581 ns | 0.0239 ns | 0.0224 ns | 11.6611 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 | 11.5617 ns | 0.0109 ns | 0.0097 ns | 11.5622 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 | 11.8351 ns | 0.0137 ns | 0.0128 ns | 11.8350 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 | 11.7509 ns | 0.0148 ns | 0.0138 ns | 11.7516 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  6.6592 ns | 0.1279 ns | 0.1196 ns |  6.7375 ns |  0.56 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 | 11.9334 ns | 0.0133 ns | 0.0118 ns | 11.9352 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 | 12.0281 ns | 0.0161 ns | 0.0134 ns | 12.0292 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  1.0062 ns | 0.0039 ns | 0.0037 ns |  1.0054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  1.0057 ns | 0.0037 ns | 0.0033 ns |  1.0056 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.9948 ns | 0.0033 ns | 0.0028 ns |  0.9943 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 | 11.1416 ns | 0.0183 ns | 0.0172 ns | 11.1355 ns | 11.07 |    0.05 |     - |     - |     - |         - |
             FromChar |        net472 | 11.1066 ns | 0.0127 ns | 0.0112 ns | 11.1099 ns | 11.04 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.4336 ns | 0.0023 ns | 0.0022 ns |  1.4330 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.5980 ns | 0.0034 ns | 0.0030 ns |  1.5977 ns |  1.11 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.4135 ns | 0.0023 ns | 0.0022 ns |  1.4134 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 | 11.4520 ns | 0.0385 ns | 0.0342 ns | 11.4558 ns |  7.99 |    0.03 |     - |     - |     - |         - |
     FromCharNullable |        net472 | 11.5674 ns | 0.0154 ns | 0.0128 ns | 11.5672 ns |  8.07 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 | 11.1558 ns | 0.0486 ns | 0.0454 ns | 11.1388 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 | 11.1754 ns | 0.0181 ns | 0.0170 ns | 11.1723 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  6.3894 ns | 0.1399 ns | 0.1309 ns |  6.3009 ns |  0.57 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 | 11.3546 ns | 0.0156 ns | 0.0146 ns | 11.3496 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 | 11.3466 ns | 0.0133 ns | 0.0118 ns | 11.3496 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 | 11.8444 ns | 0.0220 ns | 0.0195 ns | 11.8399 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 | 11.7237 ns | 0.0277 ns | 0.0259 ns | 11.7311 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  6.6594 ns | 0.1224 ns | 0.1145 ns |  6.7413 ns |  0.56 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 | 17.5798 ns | 0.0315 ns | 0.0246 ns | 17.5782 ns |  1.48 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 | 11.6676 ns | 0.0179 ns | 0.0150 ns | 11.6621 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 | 11.3764 ns | 0.0105 ns | 0.0093 ns | 11.3759 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 | 11.1676 ns | 0.0146 ns | 0.0136 ns | 11.1628 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  6.3904 ns | 0.1208 ns | 0.1130 ns |  6.3145 ns |  0.56 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 | 11.1127 ns | 0.0147 ns | 0.0138 ns | 11.1092 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 | 11.1169 ns | 0.0104 ns | 0.0097 ns | 11.1162 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 | 11.8422 ns | 0.0155 ns | 0.0138 ns | 11.8372 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 | 11.6212 ns | 0.0132 ns | 0.0123 ns | 11.6189 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  6.6064 ns | 0.1163 ns | 0.1088 ns |  6.5409 ns |  0.56 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 | 11.7887 ns | 0.0120 ns | 0.0107 ns | 11.7881 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 | 16.6346 ns | 0.0193 ns | 0.0172 ns | 16.6313 ns |  1.40 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 | 11.1438 ns | 0.0157 ns | 0.0139 ns | 11.1438 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 | 11.1746 ns | 0.0117 ns | 0.0103 ns | 11.1750 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  6.4020 ns | 0.1286 ns | 0.1203 ns |  6.3124 ns |  0.57 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 | 11.1179 ns | 0.0171 ns | 0.0152 ns | 11.1142 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 | 11.3443 ns | 0.0142 ns | 0.0133 ns | 11.3385 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 | 11.9943 ns | 0.0120 ns | 0.0107 ns | 11.9935 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 | 11.8652 ns | 0.0073 ns | 0.0068 ns | 11.8653 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  6.6316 ns | 0.1237 ns | 0.1157 ns |  6.5569 ns |  0.55 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 | 11.8200 ns | 0.0164 ns | 0.0137 ns | 11.8206 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 | 11.8468 ns | 0.0497 ns | 0.0465 ns | 11.8280 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 | 11.3521 ns | 0.0096 ns | 0.0090 ns | 11.3514 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 | 11.2626 ns | 0.0182 ns | 0.0161 ns | 11.2590 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  6.4935 ns | 0.0920 ns | 0.0816 ns |  6.5259 ns |  0.57 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 | 11.1191 ns | 0.0113 ns | 0.0094 ns | 11.1209 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 | 11.1086 ns | 0.0142 ns | 0.0126 ns | 11.1082 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 | 11.6573 ns | 0.0648 ns | 0.0607 ns | 11.6264 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 | 11.8677 ns | 0.0251 ns | 0.0222 ns | 11.8660 ns |  1.02 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  6.6753 ns | 0.1197 ns | 0.1120 ns |  6.7429 ns |  0.57 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 | 11.6099 ns | 0.0255 ns | 0.0239 ns | 11.6044 ns |  1.00 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 | 11.8053 ns | 0.0134 ns | 0.0125 ns | 11.8026 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 | 11.3821 ns | 0.0132 ns | 0.0117 ns | 11.3809 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 | 11.4720 ns | 0.0184 ns | 0.0172 ns | 11.4729 ns |  1.01 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  6.4304 ns | 0.1516 ns | 0.1418 ns |  6.4995 ns |  0.56 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 | 11.3621 ns | 0.0341 ns | 0.0319 ns | 11.3538 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 | 11.4498 ns | 0.0322 ns | 0.0285 ns | 11.4553 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 | 11.8623 ns | 0.0212 ns | 0.0188 ns | 11.8593 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 | 11.6304 ns | 0.0136 ns | 0.0127 ns | 11.6305 ns |  0.98 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  6.6548 ns | 0.1297 ns | 0.1214 ns |  6.6216 ns |  0.56 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 | 11.5909 ns | 0.0205 ns | 0.0191 ns | 11.5870 ns |  0.98 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 | 11.5816 ns | 0.0229 ns | 0.0214 ns | 11.5757 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 | 11.3731 ns | 0.0178 ns | 0.0158 ns | 11.3681 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 | 11.1780 ns | 0.0126 ns | 0.0111 ns | 11.1784 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  6.4301 ns | 0.1200 ns | 0.1122 ns |  6.5016 ns |  0.57 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 | 11.4900 ns | 0.0390 ns | 0.0365 ns | 11.4942 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 | 11.1191 ns | 0.0220 ns | 0.0172 ns | 11.1151 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 | 11.3825 ns | 0.0102 ns | 0.0090 ns | 11.3848 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 | 11.3853 ns | 0.0149 ns | 0.0132 ns | 11.3848 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  6.6728 ns | 0.1440 ns | 0.1347 ns |  6.7472 ns |  0.59 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 | 11.6065 ns | 0.0143 ns | 0.0119 ns | 11.6022 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 | 11.7966 ns | 0.0155 ns | 0.0145 ns | 11.7988 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 | 11.6326 ns | 0.0661 ns | 0.0618 ns | 11.5971 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 | 11.4021 ns | 0.0158 ns | 0.0140 ns | 11.4000 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  6.2695 ns | 0.0103 ns | 0.0086 ns |  6.2711 ns |  0.54 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 | 11.6261 ns | 0.0135 ns | 0.0126 ns | 11.6237 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 | 11.6927 ns | 0.0093 ns | 0.0087 ns | 11.6916 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 | 12.3336 ns | 0.0164 ns | 0.0145 ns | 12.3330 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 | 12.6548 ns | 0.0193 ns | 0.0171 ns | 12.6541 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  7.1518 ns | 0.1500 ns | 0.1403 ns |  7.0613 ns |  0.58 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 | 12.6923 ns | 0.0162 ns | 0.0143 ns | 12.6896 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 | 12.9060 ns | 0.0115 ns | 0.0102 ns | 12.9066 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 | 11.2704 ns | 0.0137 ns | 0.0115 ns | 11.2748 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 | 11.3943 ns | 0.0089 ns | 0.0084 ns | 11.3954 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  6.3703 ns | 0.1248 ns | 0.1167 ns |  6.4608 ns |  0.56 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 | 11.5435 ns | 0.0085 ns | 0.0075 ns | 11.5425 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 | 11.3444 ns | 0.0190 ns | 0.0148 ns | 11.3463 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 | 12.1043 ns | 0.0172 ns | 0.0153 ns | 12.1041 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 | 12.6115 ns | 0.0535 ns | 0.0500 ns | 12.6334 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  7.1405 ns | 0.1405 ns | 0.1314 ns |  7.0495 ns |  0.59 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 | 12.4254 ns | 0.0570 ns | 0.0505 ns | 12.4426 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 | 12.3041 ns | 0.0151 ns | 0.0126 ns | 12.3052 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 | 23.1711 ns | 0.0587 ns | 0.0521 ns | 23.1551 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 | 23.1564 ns | 0.0208 ns | 0.0195 ns | 23.1574 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 | 10.9338 ns | 0.0241 ns | 0.0214 ns | 10.9272 ns |  0.47 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 | 23.3029 ns | 0.0324 ns | 0.0288 ns | 23.3004 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 | 23.5637 ns | 0.0304 ns | 0.0285 ns | 23.5619 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 | 23.0834 ns | 0.0253 ns | 0.0212 ns | 23.0829 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 | 23.4397 ns | 0.0719 ns | 0.0672 ns | 23.4270 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 | 10.9328 ns | 0.0149 ns | 0.0132 ns | 10.9333 ns |  0.47 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 | 29.2766 ns | 0.1770 ns | 0.1655 ns | 29.1972 ns |  1.27 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 | 29.2258 ns | 0.0403 ns | 0.0337 ns | 29.2200 ns |  1.27 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 | 53.6441 ns | 0.0793 ns | 0.0703 ns | 53.6401 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 | 53.8302 ns | 0.0560 ns | 0.0467 ns | 53.8360 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 | 11.8281 ns | 0.0129 ns | 0.0114 ns | 11.8301 ns |  0.22 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 | 53.9106 ns | 0.0776 ns | 0.0726 ns | 53.9023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 | 53.9028 ns | 0.0749 ns | 0.0701 ns | 53.8773 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 54.1600 ns | 0.0593 ns | 0.0526 ns | 54.1516 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 | 54.6489 ns | 0.1583 ns | 0.1481 ns | 54.6963 ns |  1.01 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 | 12.3179 ns | 0.0148 ns | 0.0139 ns | 12.3106 ns |  0.23 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 | 61.8071 ns | 0.0700 ns | 0.0621 ns | 61.8137 ns |  1.14 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 | 61.8426 ns | 0.0907 ns | 0.0708 ns | 61.8497 ns |  1.14 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |  1.1502 ns | 0.0030 ns | 0.0028 ns |  1.1499 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |  1.4864 ns | 0.0035 ns | 0.0031 ns |  1.4857 ns |  1.29 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  1.3841 ns | 0.0161 ns | 0.0151 ns |  1.3906 ns |  1.20 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 |  1.4037 ns | 0.0094 ns | 0.0083 ns |  1.4004 ns |  1.22 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net472 |  1.4365 ns | 0.0042 ns | 0.0037 ns |  1.4371 ns |  1.25 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  3.9799 ns | 0.0073 ns | 0.0064 ns |  3.9790 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  3.9491 ns | 0.0052 ns | 0.0046 ns |  3.9482 ns |  0.99 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  3.9736 ns | 0.0090 ns | 0.0080 ns |  3.9715 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  3.9413 ns | 0.0063 ns | 0.0059 ns |  3.9397 ns |  0.99 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  3.9635 ns | 0.0079 ns | 0.0074 ns |  3.9615 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  1.1261 ns | 0.0029 ns | 0.0025 ns |  1.1265 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  1.1949 ns | 0.0038 ns | 0.0034 ns |  1.1949 ns |  1.06 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  1.2121 ns | 0.0016 ns | 0.0014 ns |  1.2123 ns |  1.08 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 | 11.4564 ns | 0.0077 ns | 0.0072 ns | 11.4563 ns | 10.17 |    0.02 |     - |     - |     - |         - |
         FromDateTime |        net472 | 11.3520 ns | 0.0168 ns | 0.0149 ns | 11.3561 ns | 10.08 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  8.0041 ns | 0.0307 ns | 0.0287 ns |  8.0193 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  8.6447 ns | 0.0300 ns | 0.0281 ns |  8.6457 ns |  1.08 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.7788 ns | 0.0049 ns | 0.0043 ns |  1.7798 ns |  0.22 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 | 12.0808 ns | 0.0245 ns | 0.0229 ns | 12.0803 ns |  1.51 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 | 12.1146 ns | 0.0309 ns | 0.0289 ns | 12.1032 ns |  1.51 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  8.1489 ns | 0.0152 ns | 0.0135 ns |  8.1457 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  8.3128 ns | 0.0120 ns | 0.0101 ns |  8.3146 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.2971 ns | 0.0062 ns | 0.0055 ns |  2.2950 ns |  0.28 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  8.3981 ns | 0.0175 ns | 0.0146 ns |  8.3901 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  8.4322 ns | 0.0141 ns | 0.0132 ns |  8.4323 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 76.1281 ns | 0.4237 ns | 0.3963 ns | 76.0837 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 70.6373 ns | 0.0694 ns | 0.0580 ns | 70.6377 ns |  0.93 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 44.9481 ns | 0.3385 ns | 0.3166 ns | 45.0931 ns |  0.59 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 75.9182 ns | 0.1817 ns | 0.1611 ns | 75.9099 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 | 75.5546 ns | 0.0882 ns | 0.0782 ns | 75.5460 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 | 11.3968 ns | 0.0103 ns | 0.0080 ns | 11.3970 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 | 11.3948 ns | 0.0128 ns | 0.0114 ns | 11.3910 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  6.4067 ns | 0.1256 ns | 0.1175 ns |  6.4814 ns |  0.56 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 | 11.4842 ns | 0.0821 ns | 0.0768 ns | 11.4986 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 | 11.3565 ns | 0.0253 ns | 0.0224 ns | 11.3526 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 | 11.6480 ns | 0.0119 ns | 0.0112 ns | 11.6501 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 | 11.8700 ns | 0.0178 ns | 0.0166 ns | 11.8712 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  6.6289 ns | 0.1328 ns | 0.1242 ns |  6.5263 ns |  0.57 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 | 11.6027 ns | 0.0191 ns | 0.0149 ns | 11.6028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 | 11.9341 ns | 0.0186 ns | 0.0165 ns | 11.9305 ns |  1.02 |    0.00 |     - |     - |     - |         - |
