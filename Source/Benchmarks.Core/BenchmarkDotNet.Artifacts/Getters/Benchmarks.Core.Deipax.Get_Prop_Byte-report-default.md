
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
             ToBool | .NET Core 2.0 |  0.9451 ns | 0.0036 ns | 0.0028 ns |  0.9448 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  0.9476 ns | 0.0022 ns | 0.0021 ns |  0.9475 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  0.9398 ns | 0.0046 ns | 0.0043 ns |  0.9394 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |  0.7209 ns | 0.0030 ns | 0.0028 ns |  0.7196 ns |  0.76 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |  0.7271 ns | 0.0020 ns | 0.0018 ns |  0.7274 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  3.9853 ns | 0.0069 ns | 0.0065 ns |  3.9855 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.1608 ns | 0.0213 ns | 0.0199 ns |  4.1689 ns |  1.04 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  3.9651 ns | 0.0060 ns | 0.0056 ns |  3.9660 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1663 ns | 0.0071 ns | 0.0059 ns |  4.1673 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1606 ns | 0.0139 ns | 0.0130 ns |  4.1561 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  0.9117 ns | 0.0017 ns | 0.0015 ns |  0.9116 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  0.8805 ns | 0.0034 ns | 0.0032 ns |  0.8795 ns |  0.97 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  0.9228 ns | 0.0029 ns | 0.0024 ns |  0.9230 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  0.7276 ns | 0.0025 ns | 0.0022 ns |  0.7268 ns |  0.80 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  0.7310 ns | 0.0075 ns | 0.0071 ns |  0.7275 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.0015 ns | 0.0071 ns | 0.0063 ns |  3.9993 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.1199 ns | 0.0046 ns | 0.0043 ns |  4.1193 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  3.9658 ns | 0.0047 ns | 0.0044 ns |  3.9657 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.1648 ns | 0.0040 ns | 0.0033 ns |  4.1651 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.1485 ns | 0.0051 ns | 0.0048 ns |  4.1487 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.2324 ns | 0.0134 ns | 0.0125 ns |  1.2383 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.4516 ns | 0.0019 ns | 0.0017 ns |  1.4512 ns |  1.18 |    0.01 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  0.9750 ns | 0.0030 ns | 0.0026 ns |  0.9750 ns |  0.79 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.6184 ns | 0.0031 ns | 0.0029 ns |  1.6185 ns |  1.31 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.6462 ns | 0.0022 ns | 0.0020 ns |  1.6463 ns |  1.34 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.0001 ns | 0.0050 ns | 0.0045 ns |  4.0009 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.1209 ns | 0.0049 ns | 0.0046 ns |  4.1214 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  3.9988 ns | 0.0131 ns | 0.0123 ns |  4.0020 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.8618 ns | 0.0087 ns | 0.0081 ns |  4.8602 ns |  1.22 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.8428 ns | 0.0068 ns | 0.0063 ns |  4.8428 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  0.9504 ns | 0.0162 ns | 0.0152 ns |  0.9571 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  0.9030 ns | 0.0100 ns | 0.0094 ns |  0.9079 ns |  0.95 |    0.02 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  0.9226 ns | 0.0029 ns | 0.0025 ns |  0.9233 ns |  0.97 |    0.02 |      - |     - |     - |         - |
             ToByte |        net461 |  0.6987 ns | 0.0024 ns | 0.0022 ns |  0.6990 ns |  0.74 |    0.01 |      - |     - |     - |         - |
             ToByte |        net472 |  0.7524 ns | 0.0023 ns | 0.0022 ns |  0.7520 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.0144 ns | 0.0250 ns | 0.0234 ns |  4.0292 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.3634 ns | 0.0059 ns | 0.0052 ns |  4.3639 ns |  1.09 |    0.01 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.2308 ns | 0.0153 ns | 0.0135 ns |  4.2299 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.2024 ns | 0.0166 ns | 0.0155 ns |  4.2079 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.1711 ns | 0.0202 ns | 0.0189 ns |  4.1767 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  0.9446 ns | 0.0023 ns | 0.0022 ns |  0.9443 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  0.8802 ns | 0.0024 ns | 0.0021 ns |  0.8805 ns |  0.93 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  0.9384 ns | 0.0029 ns | 0.0027 ns |  0.9389 ns |  0.99 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |  0.7270 ns | 0.0101 ns | 0.0094 ns |  0.7206 ns |  0.77 |    0.01 |      - |     - |     - |         - |
            ToShort |        net472 |  0.7245 ns | 0.0028 ns | 0.0023 ns |  0.7246 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.0056 ns | 0.0120 ns | 0.0112 ns |  4.0030 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.1215 ns | 0.0059 ns | 0.0053 ns |  4.1214 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  3.9650 ns | 0.0046 ns | 0.0038 ns |  3.9650 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.1654 ns | 0.0042 ns | 0.0040 ns |  4.1664 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.1723 ns | 0.0274 ns | 0.0256 ns |  4.1592 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  0.9214 ns | 0.0019 ns | 0.0017 ns |  0.9215 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  0.9017 ns | 0.0123 ns | 0.0115 ns |  0.9069 ns |  0.98 |    0.01 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  0.9263 ns | 0.0029 ns | 0.0027 ns |  0.9277 ns |  1.01 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |  0.7214 ns | 0.0026 ns | 0.0022 ns |  0.7213 ns |  0.78 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  0.7282 ns | 0.0023 ns | 0.0021 ns |  0.7278 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.0137 ns | 0.0217 ns | 0.0203 ns |  4.0002 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.1283 ns | 0.0069 ns | 0.0061 ns |  4.1299 ns |  1.03 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  3.9657 ns | 0.0056 ns | 0.0047 ns |  3.9663 ns |  0.99 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.1663 ns | 0.0087 ns | 0.0081 ns |  4.1654 ns |  1.04 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.1730 ns | 0.0311 ns | 0.0291 ns |  4.1615 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  0.9220 ns | 0.0031 ns | 0.0029 ns |  0.9222 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  0.8894 ns | 0.0122 ns | 0.0114 ns |  0.8874 ns |  0.96 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  0.9327 ns | 0.0067 ns | 0.0059 ns |  0.9330 ns |  1.01 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |  0.7053 ns | 0.0103 ns | 0.0096 ns |  0.7068 ns |  0.77 |    0.01 |      - |     - |     - |         - |
              ToInt |        net472 |  0.7269 ns | 0.0017 ns | 0.0015 ns |  0.7273 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.0153 ns | 0.0249 ns | 0.0233 ns |  4.0072 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.1208 ns | 0.0049 ns | 0.0041 ns |  4.1216 ns |  1.03 |    0.01 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  3.9629 ns | 0.0062 ns | 0.0058 ns |  3.9645 ns |  0.99 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.1741 ns | 0.0161 ns | 0.0142 ns |  4.1712 ns |  1.04 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.1746 ns | 0.0235 ns | 0.0220 ns |  4.1855 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  0.9498 ns | 0.0031 ns | 0.0028 ns |  0.9500 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  0.8787 ns | 0.0018 ns | 0.0016 ns |  0.8787 ns |  0.93 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  0.9298 ns | 0.0108 ns | 0.0101 ns |  0.9261 ns |  0.98 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net461 |  0.6995 ns | 0.0027 ns | 0.0024 ns |  0.6996 ns |  0.74 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |  0.7529 ns | 0.0025 ns | 0.0023 ns |  0.7527 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.0071 ns | 0.0224 ns | 0.0210 ns |  3.9981 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.1211 ns | 0.0072 ns | 0.0067 ns |  4.1214 ns |  1.03 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  3.9687 ns | 0.0091 ns | 0.0085 ns |  3.9707 ns |  0.99 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.1675 ns | 0.0063 ns | 0.0056 ns |  4.1684 ns |  1.04 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.1498 ns | 0.0038 ns | 0.0036 ns |  4.1492 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  0.9508 ns | 0.0029 ns | 0.0027 ns |  0.9511 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  0.8837 ns | 0.0031 ns | 0.0028 ns |  0.8841 ns |  0.93 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  0.9388 ns | 0.0037 ns | 0.0031 ns |  0.9382 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |  0.7229 ns | 0.0023 ns | 0.0020 ns |  0.7227 ns |  0.76 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  0.7249 ns | 0.0023 ns | 0.0020 ns |  0.7250 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.6441 ns | 0.0025 ns | 0.0024 ns |  1.6441 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.4606 ns | 0.0126 ns | 0.0112 ns |  1.4560 ns |  0.89 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.5500 ns | 0.0047 ns | 0.0042 ns |  1.5495 ns |  0.94 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  1.7529 ns | 0.0030 ns | 0.0026 ns |  1.7518 ns |  1.07 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  1.6199 ns | 0.0120 ns | 0.0112 ns |  1.6149 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  0.9571 ns | 0.0100 ns | 0.0089 ns |  0.9611 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  0.9048 ns | 0.0114 ns | 0.0106 ns |  0.9116 ns |  0.94 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  0.9239 ns | 0.0032 ns | 0.0026 ns |  0.9235 ns |  0.96 |    0.01 |      - |     - |     - |         - |
            ToULong |        net461 |  0.7213 ns | 0.0030 ns | 0.0025 ns |  0.7212 ns |  0.75 |    0.01 |      - |     - |     - |         - |
            ToULong |        net472 |  0.7241 ns | 0.0048 ns | 0.0040 ns |  0.7239 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.6457 ns | 0.0051 ns | 0.0048 ns |  1.6445 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.5554 ns | 0.0039 ns | 0.0034 ns |  1.5551 ns |  0.94 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.4679 ns | 0.0020 ns | 0.0018 ns |  1.4679 ns |  0.89 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  1.7495 ns | 0.0039 ns | 0.0032 ns |  1.7482 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  1.5661 ns | 0.0025 ns | 0.0022 ns |  1.5655 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.1781 ns | 0.0039 ns | 0.0035 ns |  1.1788 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.0976 ns | 0.0095 ns | 0.0079 ns |  1.0992 ns |  0.93 |    0.01 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.0968 ns | 0.0031 ns | 0.0029 ns |  1.0963 ns |  0.93 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.7004 ns | 0.0021 ns | 0.0020 ns |  0.7002 ns |  0.59 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.7164 ns | 0.0095 ns | 0.0084 ns |  0.7184 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2294 ns | 0.0040 ns | 0.0033 ns |  4.2297 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.3510 ns | 0.0032 ns | 0.0030 ns |  4.3505 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.1981 ns | 0.0065 ns | 0.0061 ns |  4.1957 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.4037 ns | 0.0059 ns | 0.0049 ns |  4.4061 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.3773 ns | 0.0055 ns | 0.0049 ns |  4.3770 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.4080 ns | 0.0031 ns | 0.0026 ns |  1.4078 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.2002 ns | 0.0032 ns | 0.0030 ns |  1.2001 ns |  0.85 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.0890 ns | 0.0028 ns | 0.0026 ns |  1.0890 ns |  0.77 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.7117 ns | 0.0065 ns | 0.0061 ns |  0.7136 ns |  0.51 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.7458 ns | 0.0042 ns | 0.0039 ns |  0.7453 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.8738 ns | 0.0024 ns | 0.0023 ns |  1.8738 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.6226 ns | 0.0035 ns | 0.0033 ns |  1.6217 ns |  0.87 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.4384 ns | 0.0034 ns | 0.0031 ns |  1.4382 ns |  0.77 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.7909 ns | 0.0030 ns | 0.0026 ns |  1.7905 ns |  0.96 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.5624 ns | 0.0082 ns | 0.0072 ns |  1.5604 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  5.8362 ns | 0.0077 ns | 0.0072 ns |  5.8353 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  5.7321 ns | 0.0066 ns | 0.0058 ns |  5.7320 ns |  0.98 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  5.7968 ns | 0.0086 ns | 0.0080 ns |  5.7966 ns |  0.99 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  5.7946 ns | 0.0298 ns | 0.0278 ns |  5.7826 ns |  0.99 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  5.7652 ns | 0.0109 ns | 0.0091 ns |  5.7615 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.6477 ns | 0.0697 ns | 0.0652 ns | 18.6653 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 17.9700 ns | 0.0249 ns | 0.0221 ns | 17.9722 ns |  0.96 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 12.7969 ns | 0.1095 ns | 0.1025 ns | 12.8445 ns |  0.69 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 17.7700 ns | 0.0196 ns | 0.0183 ns | 17.7704 ns |  0.95 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.0126 ns | 0.0531 ns | 0.0471 ns | 18.0033 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3365 ns | 0.0032 ns | 0.0028 ns |  2.3362 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.0380 ns | 0.0161 ns | 0.0151 ns |  2.0291 ns |  0.87 |    0.01 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.0552 ns | 0.0042 ns | 0.0037 ns |  2.0545 ns |  0.88 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1848 ns | 0.0071 ns | 0.0066 ns |  1.1867 ns |  0.51 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1311 ns | 0.0036 ns | 0.0033 ns |  1.1307 ns |  0.48 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.4287 ns | 0.0109 ns | 0.0097 ns |  8.4317 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.2470 ns | 0.0098 ns | 0.0087 ns |  8.2442 ns |  0.98 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.8846 ns | 0.0041 ns | 0.0032 ns |  1.8845 ns |  0.22 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.2722 ns | 0.0130 ns | 0.0121 ns |  8.2751 ns |  0.98 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.1690 ns | 0.0126 ns | 0.0118 ns |  8.1692 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.2517 ns | 0.0055 ns | 0.0049 ns |  3.2504 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  3.9342 ns | 0.0088 ns | 0.0082 ns |  3.9371 ns |  1.21 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  3.7601 ns | 0.0259 ns | 0.0230 ns |  3.7608 ns |  1.16 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  2.6844 ns | 0.0125 ns | 0.0104 ns |  2.6808 ns |  0.83 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  2.7372 ns | 0.0231 ns | 0.0205 ns |  2.7381 ns |  0.84 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 28.4761 ns | 0.0957 ns | 0.0895 ns | 28.4543 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 17.1671 ns | 0.0591 ns | 0.0553 ns | 17.1772 ns |  0.60 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 11.8421 ns | 0.0203 ns | 0.0170 ns | 11.8402 ns |  0.42 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 31.1210 ns | 0.0432 ns | 0.0404 ns | 31.1189 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 30.1780 ns | 0.0342 ns | 0.0303 ns | 30.1806 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 10.0691 ns | 0.0353 ns | 0.0330 ns | 10.0605 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 10.2583 ns | 0.0130 ns | 0.0121 ns | 10.2565 ns |  1.02 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.2110 ns | 0.0096 ns | 0.0090 ns |  8.2082 ns |  0.82 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 12.0735 ns | 0.0258 ns | 0.0216 ns | 12.0711 ns |  1.20 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 12.1703 ns | 0.0508 ns | 0.0451 ns | 12.1547 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 14.2972 ns | 0.0173 ns | 0.0162 ns | 14.2983 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 14.9235 ns | 0.0240 ns | 0.0200 ns | 14.9274 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 12.5205 ns | 0.0132 ns | 0.0110 ns | 12.5244 ns |  0.88 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 16.8869 ns | 0.0607 ns | 0.0567 ns | 16.8993 ns |  1.18 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 16.7663 ns | 0.0195 ns | 0.0173 ns | 16.7671 ns |  1.17 |    0.00 |      - |     - |     - |         - |
