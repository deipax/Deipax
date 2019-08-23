
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
             FromBool | .NET Core 2.0 | 17.6355 ns | 0.0384 ns | 0.0300 ns | 17.6394 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 | 17.4402 ns | 0.1552 ns | 0.1451 ns | 17.3593 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 | 11.9913 ns | 0.2501 ns | 0.2340 ns | 11.8143 ns |  0.68 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 | 17.2597 ns | 0.0552 ns | 0.0490 ns | 17.2706 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 | 17.3564 ns | 0.0295 ns | 0.0246 ns | 17.3480 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  9.5503 ns | 0.0133 ns | 0.0124 ns |  9.5489 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 | 10.0033 ns | 0.0544 ns | 0.0509 ns |  9.9805 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.7334 ns | 0.0163 ns | 0.0152 ns |  1.7288 ns |  0.18 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 | 11.3130 ns | 0.0111 ns | 0.0104 ns | 11.3161 ns |  1.18 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 | 11.3125 ns | 0.0128 ns | 0.0119 ns | 11.3091 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9198 ns | 0.0042 ns | 0.0039 ns |  0.9192 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.7408 ns | 0.0030 ns | 0.0025 ns |  0.7411 ns |  0.81 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.6372 ns | 0.0020 ns | 0.0019 ns |  0.6373 ns |  0.69 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  0.7057 ns | 0.0022 ns | 0.0020 ns |  0.7062 ns |  0.77 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.7314 ns | 0.0024 ns | 0.0021 ns |  0.7313 ns |  0.80 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.9160 ns | 0.0061 ns | 0.0051 ns |  0.9143 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.0083 ns | 0.0032 ns | 0.0027 ns |  1.0088 ns |  1.10 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.8798 ns | 0.0027 ns | 0.0026 ns |  0.8796 ns |  0.96 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  0.9766 ns | 0.0038 ns | 0.0034 ns |  0.9764 ns |  1.07 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  0.9910 ns | 0.0023 ns | 0.0020 ns |  0.9906 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 | 17.3353 ns | 0.0183 ns | 0.0162 ns | 17.3320 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 | 17.2115 ns | 0.1065 ns | 0.0996 ns | 17.2717 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 | 11.6623 ns | 0.1453 ns | 0.1359 ns | 11.6701 ns |  0.67 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 | 27.4080 ns | 0.0342 ns | 0.0304 ns | 27.4004 ns |  1.58 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 | 16.8375 ns | 0.0210 ns | 0.0197 ns | 16.8364 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  9.5520 ns | 0.0101 ns | 0.0090 ns |  9.5508 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  9.9471 ns | 0.0236 ns | 0.0221 ns |  9.9508 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.7736 ns | 0.0041 ns | 0.0038 ns |  1.7730 ns |  0.19 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 | 11.3178 ns | 0.0149 ns | 0.0132 ns | 11.3178 ns |  1.18 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 | 11.3446 ns | 0.0190 ns | 0.0168 ns | 11.3418 ns |  1.19 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 | 17.3531 ns | 0.0147 ns | 0.0130 ns | 17.3503 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 | 17.1213 ns | 0.0419 ns | 0.0392 ns | 17.1226 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 | 12.1219 ns | 0.1985 ns | 0.1857 ns | 12.2110 ns |  0.70 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 | 17.1108 ns | 0.0276 ns | 0.0230 ns | 17.1113 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 | 17.7166 ns | 0.0183 ns | 0.0162 ns | 17.7202 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  9.5446 ns | 0.0193 ns | 0.0171 ns |  9.5447 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 | 11.6194 ns | 0.0739 ns | 0.0691 ns | 11.6652 ns |  1.22 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.7544 ns | 0.0140 ns | 0.0131 ns |  1.7492 ns |  0.18 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 | 11.3219 ns | 0.0203 ns | 0.0190 ns | 11.3231 ns |  1.19 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 | 11.2980 ns | 0.0083 ns | 0.0073 ns | 11.2989 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 | 17.3668 ns | 0.0287 ns | 0.0268 ns | 17.3647 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 | 17.0914 ns | 0.0312 ns | 0.0261 ns | 17.0895 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 | 11.5702 ns | 0.0153 ns | 0.0143 ns | 11.5744 ns |  0.67 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 | 17.4932 ns | 0.0153 ns | 0.0143 ns | 17.4899 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 | 16.8528 ns | 0.0268 ns | 0.0251 ns | 16.8516 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  9.7898 ns | 0.0073 ns | 0.0068 ns |  9.7887 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  9.9889 ns | 0.0185 ns | 0.0173 ns |  9.9878 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.8159 ns | 0.0063 ns | 0.0059 ns |  1.8169 ns |  0.19 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 | 11.1729 ns | 0.0183 ns | 0.0162 ns | 11.1685 ns |  1.14 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 | 11.2725 ns | 0.0146 ns | 0.0129 ns | 11.2700 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 | 16.9448 ns | 0.0212 ns | 0.0177 ns | 16.9414 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 | 16.8267 ns | 0.0287 ns | 0.0240 ns | 16.8227 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 | 12.1154 ns | 0.2537 ns | 0.2605 ns | 12.1978 ns |  0.71 |    0.02 |     - |     - |     - |         - |
           FromUShort |        net461 | 17.1052 ns | 0.0469 ns | 0.0439 ns | 17.0909 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 | 17.3334 ns | 0.1080 ns | 0.1010 ns | 17.3497 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  9.7104 ns | 0.0565 ns | 0.0529 ns |  9.6823 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  9.9734 ns | 0.0152 ns | 0.0142 ns |  9.9763 ns |  1.03 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.8655 ns | 0.0040 ns | 0.0036 ns |  1.8659 ns |  0.19 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 | 11.1320 ns | 0.0136 ns | 0.0127 ns | 11.1339 ns |  1.15 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 | 11.2011 ns | 0.0702 ns | 0.0657 ns | 11.1690 ns |  1.15 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 | 16.8750 ns | 0.0261 ns | 0.0245 ns | 16.8761 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 | 17.0859 ns | 0.0486 ns | 0.0455 ns | 17.0686 ns |  1.01 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 | 11.7483 ns | 0.1105 ns | 0.1034 ns | 11.8059 ns |  0.70 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 | 17.0926 ns | 0.0245 ns | 0.0229 ns | 17.0982 ns |  1.01 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 | 17.0590 ns | 0.0321 ns | 0.0284 ns | 17.0493 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  9.6881 ns | 0.0275 ns | 0.0244 ns |  9.6856 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  9.9668 ns | 0.0161 ns | 0.0143 ns |  9.9683 ns |  1.03 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.8542 ns | 0.0130 ns | 0.0115 ns |  1.8545 ns |  0.19 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 | 11.1298 ns | 0.0194 ns | 0.0181 ns | 11.1339 ns |  1.15 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 | 11.1599 ns | 0.0479 ns | 0.0448 ns | 11.1495 ns |  1.15 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 | 16.4264 ns | 0.0328 ns | 0.0256 ns | 16.4285 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 | 16.5983 ns | 0.0272 ns | 0.0241 ns | 16.6022 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 | 11.7453 ns | 0.0977 ns | 0.0914 ns | 11.7682 ns |  0.71 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 | 17.3115 ns | 0.0188 ns | 0.0176 ns | 17.3108 ns |  1.05 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 | 16.8725 ns | 0.0243 ns | 0.0228 ns | 16.8620 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  9.6708 ns | 0.0112 ns | 0.0093 ns |  9.6718 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  9.9680 ns | 0.0270 ns | 0.0210 ns |  9.9726 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.8704 ns | 0.0044 ns | 0.0041 ns |  1.8704 ns |  0.19 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 | 11.1484 ns | 0.0244 ns | 0.0228 ns | 11.1453 ns |  1.15 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 | 12.7151 ns | 0.0249 ns | 0.0233 ns | 12.7060 ns |  1.32 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 | 16.6703 ns | 0.0249 ns | 0.0233 ns | 16.6610 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 | 16.7998 ns | 0.0359 ns | 0.0318 ns | 16.7972 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 | 11.8272 ns | 0.0178 ns | 0.0139 ns | 11.8243 ns |  0.71 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 | 17.0734 ns | 0.0176 ns | 0.0147 ns | 17.0782 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 | 17.5045 ns | 0.0251 ns | 0.0234 ns | 17.4989 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  9.3257 ns | 0.0565 ns | 0.0529 ns |  9.2982 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  9.9875 ns | 0.0131 ns | 0.0123 ns |  9.9877 ns |  1.07 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.9192 ns | 0.0037 ns | 0.0035 ns |  1.9197 ns |  0.21 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 | 11.1562 ns | 0.0328 ns | 0.0307 ns | 11.1431 ns |  1.20 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 | 11.1410 ns | 0.0230 ns | 0.0215 ns | 11.1399 ns |  1.19 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 | 17.3585 ns | 0.0193 ns | 0.0181 ns | 17.3539 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 | 16.8513 ns | 0.0199 ns | 0.0166 ns | 16.8539 ns |  0.97 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 | 11.9759 ns | 0.2232 ns | 0.2088 ns | 11.8385 ns |  0.69 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 | 17.5169 ns | 0.0170 ns | 0.0142 ns | 17.5195 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 | 17.5077 ns | 0.0278 ns | 0.0232 ns | 17.5076 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  9.3021 ns | 0.0178 ns | 0.0158 ns |  9.3004 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 | 10.0367 ns | 0.0119 ns | 0.0105 ns | 10.0365 ns |  1.08 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.9311 ns | 0.0147 ns | 0.0138 ns |  1.9265 ns |  0.21 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 | 11.4840 ns | 0.0221 ns | 0.0207 ns | 11.4840 ns |  1.23 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 | 10.9796 ns | 0.0101 ns | 0.0094 ns | 10.9776 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 | 19.8996 ns | 0.1076 ns | 0.1007 ns | 19.8518 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 | 19.8842 ns | 0.0242 ns | 0.0202 ns | 19.8834 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  8.9587 ns | 0.1103 ns | 0.1031 ns |  8.9013 ns |  0.45 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 | 19.8452 ns | 0.0309 ns | 0.0289 ns | 19.8373 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 | 20.0536 ns | 0.0215 ns | 0.0191 ns | 20.0557 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  9.7282 ns | 0.0151 ns | 0.0142 ns |  9.7280 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 | 10.0968 ns | 0.0571 ns | 0.0534 ns | 10.1198 ns |  1.04 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  2.0978 ns | 0.0048 ns | 0.0045 ns |  2.0990 ns |  0.22 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 | 11.0630 ns | 0.0119 ns | 0.0111 ns | 11.0626 ns |  1.14 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 | 11.0633 ns | 0.0714 ns | 0.0668 ns | 11.0331 ns |  1.14 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 | 19.3673 ns | 0.1066 ns | 0.0945 ns | 19.3879 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 | 19.9742 ns | 0.0305 ns | 0.0270 ns | 19.9744 ns |  1.03 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  9.0272 ns | 0.0982 ns | 0.0918 ns |  9.0257 ns |  0.47 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 | 19.8909 ns | 0.0257 ns | 0.0228 ns | 19.8890 ns |  1.03 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 | 19.8172 ns | 0.0616 ns | 0.0514 ns | 19.8050 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 10.9729 ns | 0.0144 ns | 0.0128 ns | 10.9768 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 | 10.1104 ns | 0.0741 ns | 0.0693 ns | 10.0778 ns |  0.92 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  2.1714 ns | 0.0053 ns | 0.0049 ns |  2.1707 ns |  0.20 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 | 11.0517 ns | 0.0086 ns | 0.0072 ns | 11.0499 ns |  1.01 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 | 11.0826 ns | 0.0151 ns | 0.0141 ns | 11.0856 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |  5.5714 ns | 0.0053 ns | 0.0042 ns |  5.5715 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |  5.6003 ns | 0.0097 ns | 0.0081 ns |  5.5988 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.5792 ns | 0.0070 ns | 0.0066 ns |  5.5808 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 |  5.7948 ns | 0.0073 ns | 0.0065 ns |  5.7947 ns |  1.04 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 |  5.7727 ns | 0.0037 ns | 0.0033 ns |  5.7728 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  1.4055 ns | 0.0033 ns | 0.0027 ns |  1.4057 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  1.3890 ns | 0.0048 ns | 0.0045 ns |  1.3900 ns |  0.99 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  1.3206 ns | 0.0156 ns | 0.0146 ns |  1.3275 ns |  0.94 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  1.3557 ns | 0.0034 ns | 0.0032 ns |  1.3550 ns |  0.96 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  1.6360 ns | 0.0094 ns | 0.0088 ns |  1.6384 ns |  1.16 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9265 ns | 0.0025 ns | 0.0023 ns |  0.9271 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7692 ns | 0.0042 ns | 0.0039 ns |  0.7695 ns |  0.83 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.9505 ns | 0.0052 ns | 0.0048 ns |  0.9496 ns |  1.03 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.9661 ns | 0.0028 ns | 0.0026 ns |  0.9667 ns |  1.04 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.8874 ns | 0.0023 ns | 0.0021 ns |  0.8879 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4419 ns | 0.0036 ns | 0.0033 ns |  1.4417 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6506 ns | 0.0070 ns | 0.0059 ns |  1.6505 ns |  1.14 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.5889 ns | 0.0044 ns | 0.0035 ns |  1.5899 ns |  1.10 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6306 ns | 0.0041 ns | 0.0038 ns |  1.6313 ns |  1.13 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6243 ns | 0.0071 ns | 0.0063 ns |  1.6241 ns |  1.13 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  9.1468 ns | 0.0954 ns | 0.0892 ns |  9.1861 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  8.8244 ns | 0.0074 ns | 0.0069 ns |  8.8260 ns |  0.96 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  8.7618 ns | 0.1165 ns | 0.1090 ns |  8.8110 ns |  0.96 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  8.8815 ns | 0.0384 ns | 0.0359 ns |  8.8871 ns |  0.97 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  8.7492 ns | 0.0161 ns | 0.0151 ns |  8.7513 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  9.6979 ns | 0.0598 ns | 0.0559 ns |  9.7245 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  7.9566 ns | 0.0209 ns | 0.0195 ns |  7.9593 ns |  0.82 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.9485 ns | 0.0045 ns | 0.0042 ns |  1.9470 ns |  0.20 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 11.3261 ns | 0.0168 ns | 0.0149 ns | 11.3236 ns |  1.17 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 | 11.2873 ns | 0.0141 ns | 0.0132 ns | 11.2863 ns |  1.16 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 | 17.3183 ns | 0.0096 ns | 0.0085 ns | 17.3176 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 | 17.6050 ns | 0.1285 ns | 0.1202 ns | 17.5331 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 | 11.9883 ns | 0.2365 ns | 0.2212 ns | 11.8488 ns |  0.69 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 | 17.0884 ns | 0.0246 ns | 0.0231 ns | 17.0875 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 | 17.0668 ns | 0.0217 ns | 0.0192 ns | 17.0665 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  9.7088 ns | 0.0153 ns | 0.0119 ns |  9.7058 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  9.9610 ns | 0.0160 ns | 0.0141 ns |  9.9648 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  2.2352 ns | 0.0159 ns | 0.0149 ns |  2.2393 ns |  0.23 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 | 11.2530 ns | 0.0075 ns | 0.0070 ns | 11.2525 ns |  1.16 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 | 11.0886 ns | 0.0128 ns | 0.0113 ns | 11.0894 ns |  1.14 |    0.00 |     - |     - |     - |         - |
