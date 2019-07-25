
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-JBIYRV : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-GQVRNQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-BKGSYN : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-NLOXWC : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-AAMQWS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |   3.493 ns | 0.0128 ns | 0.0114 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromBool | .NET Core 2.2 |   3.499 ns | 0.0096 ns | 0.0085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromBool | .NET Core 3.0 |   3.524 ns | 0.0132 ns | 0.0123 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             FromBool |        net461 |   4.236 ns | 0.0103 ns | 0.0096 ns |  1.21 |    0.00 |      - |     - |     - |         - |
             FromBool |        net472 |   3.587 ns | 0.0076 ns | 0.0071 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
     FromBoolNullable | .NET Core 2.0 |   2.149 ns | 0.0069 ns | 0.0061 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |   1.837 ns | 0.0037 ns | 0.0034 ns |  0.85 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |   1.983 ns | 0.0052 ns | 0.0040 ns |  0.92 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable |        net461 |   2.269 ns | 0.0071 ns | 0.0059 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable |        net472 |   2.003 ns | 0.0076 ns | 0.0067 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
             FromChar | .NET Core 2.0 |   5.075 ns | 0.0455 ns | 0.0426 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromChar | .NET Core 2.2 |   4.843 ns | 0.0360 ns | 0.0337 ns |  0.95 |    0.01 | 0.0051 |     - |     - |      32 B |
             FromChar | .NET Core 3.0 |   4.468 ns | 0.0333 ns | 0.0311 ns |  0.88 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromChar |        net461 |   7.124 ns | 0.0383 ns | 0.0339 ns |  1.40 |    0.01 | 0.0051 |     - |     - |      32 B |
             FromChar |        net472 |   7.043 ns | 0.0301 ns | 0.0267 ns |  1.39 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
     FromCharNullable | .NET Core 2.0 |   2.337 ns | 0.0067 ns | 0.0062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |   2.216 ns | 0.0064 ns | 0.0057 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |   2.089 ns | 0.0085 ns | 0.0079 ns |  0.89 |    0.00 |      - |     - |     - |         - |
     FromCharNullable |        net461 |   2.345 ns | 0.0090 ns | 0.0084 ns |  1.00 |    0.01 |      - |     - |     - |         - |
     FromCharNullable |        net472 |   2.797 ns | 0.0077 ns | 0.0072 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
            FromSByte | .NET Core 2.0 |  30.449 ns | 0.1694 ns | 0.1502 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromSByte | .NET Core 2.2 |  18.462 ns | 0.0325 ns | 0.0304 ns |  0.61 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromSByte | .NET Core 3.0 |  14.165 ns | 0.1007 ns | 0.0942 ns |  0.47 |    0.00 |      - |     - |     - |         - |
            FromSByte |        net461 |  33.277 ns | 0.0720 ns | 0.0673 ns |  1.09 |    0.01 | 0.0051 |     - |     - |      32 B |
            FromSByte |        net472 |  33.553 ns | 0.1758 ns | 0.1558 ns |  1.10 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
    FromSByteNullable | .NET Core 2.0 |   2.171 ns | 0.0082 ns | 0.0073 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |   2.272 ns | 0.0065 ns | 0.0058 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |   2.026 ns | 0.0060 ns | 0.0056 ns |  0.93 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable |        net461 |   2.382 ns | 0.0078 ns | 0.0065 ns |  1.10 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable |        net472 |   2.047 ns | 0.0037 ns | 0.0034 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
             FromByte | .NET Core 2.0 |  30.053 ns | 0.1985 ns | 0.1857 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromByte | .NET Core 2.2 |  18.082 ns | 0.0512 ns | 0.0479 ns |  0.60 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromByte | .NET Core 3.0 |  12.943 ns | 0.0995 ns | 0.0831 ns |  0.43 |    0.00 |      - |     - |     - |         - |
             FromByte |        net461 |  33.806 ns | 0.1205 ns | 0.1127 ns |  1.12 |    0.01 | 0.0051 |     - |     - |      32 B |
             FromByte |        net472 |  33.764 ns | 0.1552 ns | 0.1452 ns |  1.12 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
     FromByteNullable | .NET Core 2.0 |   2.533 ns | 0.0047 ns | 0.0042 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |   2.307 ns | 0.0046 ns | 0.0038 ns |  0.91 |    0.00 |      - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |   1.984 ns | 0.0057 ns | 0.0044 ns |  0.78 |    0.00 |      - |     - |     - |         - |
     FromByteNullable |        net461 |   2.868 ns | 0.0092 ns | 0.0082 ns |  1.13 |    0.00 |      - |     - |     - |         - |
     FromByteNullable |        net472 |   2.453 ns | 0.0107 ns | 0.0095 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
            FromShort | .NET Core 2.0 |  29.790 ns | 0.0548 ns | 0.0458 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromShort | .NET Core 2.2 |  19.145 ns | 0.0515 ns | 0.0481 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromShort | .NET Core 3.0 |  13.568 ns | 0.1506 ns | 0.1409 ns |  0.46 |    0.00 |      - |     - |     - |         - |
            FromShort |        net461 |  33.410 ns | 0.1068 ns | 0.0947 ns |  1.12 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromShort |        net472 |  33.255 ns | 0.1843 ns | 0.1724 ns |  1.12 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
    FromShortNullable | .NET Core 2.0 |   2.315 ns | 0.0110 ns | 0.0103 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |   2.104 ns | 0.0125 ns | 0.0117 ns |  0.91 |    0.01 |      - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |   2.209 ns | 0.0067 ns | 0.0063 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    FromShortNullable |        net461 |   2.337 ns | 0.0051 ns | 0.0045 ns |  1.01 |    0.01 |      - |     - |     - |         - |
    FromShortNullable |        net472 |   2.082 ns | 0.0030 ns | 0.0024 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
           FromUShort | .NET Core 2.0 |  28.235 ns | 0.0772 ns | 0.0722 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
           FromUShort | .NET Core 2.2 |  17.890 ns | 0.0318 ns | 0.0282 ns |  0.63 |    0.00 | 0.0051 |     - |     - |      32 B |
           FromUShort | .NET Core 3.0 |  13.130 ns | 0.2179 ns | 0.2039 ns |  0.47 |    0.01 |      - |     - |     - |         - |
           FromUShort |        net461 |  31.995 ns | 0.0691 ns | 0.0647 ns |  1.13 |    0.00 | 0.0051 |     - |     - |      32 B |
           FromUShort |        net472 |  32.775 ns | 0.0961 ns | 0.0899 ns |  1.16 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
   FromUShortNullable | .NET Core 2.0 |   2.416 ns | 0.0295 ns | 0.0276 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |   2.109 ns | 0.0039 ns | 0.0036 ns |  0.87 |    0.01 |      - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |   2.249 ns | 0.0047 ns | 0.0042 ns |  0.93 |    0.01 |      - |     - |     - |         - |
   FromUShortNullable |        net461 |   2.790 ns | 0.0133 ns | 0.0124 ns |  1.15 |    0.01 |      - |     - |     - |         - |
   FromUShortNullable |        net472 |   2.455 ns | 0.0065 ns | 0.0061 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
              FromInt | .NET Core 2.0 |  30.148 ns | 0.1292 ns | 0.1209 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
              FromInt | .NET Core 2.2 |  19.254 ns | 0.0878 ns | 0.0821 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
              FromInt | .NET Core 3.0 |  13.102 ns | 0.0460 ns | 0.0430 ns |  0.43 |    0.00 |      - |     - |     - |         - |
              FromInt |        net461 |  32.955 ns | 0.0978 ns | 0.0915 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
              FromInt |        net472 |  32.953 ns | 0.1045 ns | 0.0977 ns |  1.09 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
      FromIntNullable | .NET Core 2.0 |   2.365 ns | 0.0702 ns | 0.0720 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |   2.472 ns | 0.0075 ns | 0.0066 ns |  1.04 |    0.04 |      - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |   2.246 ns | 0.0063 ns | 0.0059 ns |  0.95 |    0.03 |      - |     - |     - |         - |
      FromIntNullable |        net461 |   2.180 ns | 0.0174 ns | 0.0154 ns |  0.92 |    0.03 |      - |     - |     - |         - |
      FromIntNullable |        net472 |   2.051 ns | 0.0049 ns | 0.0041 ns |  0.86 |    0.03 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
             FromUInt | .NET Core 2.0 |  28.759 ns | 0.0489 ns | 0.0458 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromUInt | .NET Core 2.2 |  18.077 ns | 0.0386 ns | 0.0361 ns |  0.63 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromUInt | .NET Core 3.0 |  12.726 ns | 0.0677 ns | 0.0633 ns |  0.44 |    0.00 |      - |     - |     - |         - |
             FromUInt |        net461 |  31.534 ns | 0.0972 ns | 0.0812 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromUInt |        net472 |  32.423 ns | 0.0572 ns | 0.0507 ns |  1.13 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
     FromUIntNullable | .NET Core 2.0 |   2.558 ns | 0.0068 ns | 0.0063 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |   2.110 ns | 0.0041 ns | 0.0036 ns |  0.82 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |   2.243 ns | 0.0032 ns | 0.0029 ns |  0.88 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable |        net461 |   2.838 ns | 0.0242 ns | 0.0227 ns |  1.11 |    0.01 |      - |     - |     - |         - |
     FromUIntNullable |        net472 |   2.431 ns | 0.0100 ns | 0.0094 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
             FromLong | .NET Core 2.0 |  32.587 ns | 0.1561 ns | 0.1384 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromLong | .NET Core 2.2 |  19.537 ns | 0.0693 ns | 0.0578 ns |  0.60 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromLong | .NET Core 3.0 |  13.124 ns | 0.0160 ns | 0.0150 ns |  0.40 |    0.00 |      - |     - |     - |         - |
             FromLong |        net461 |  33.830 ns | 0.0941 ns | 0.0834 ns |  1.04 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromLong |        net472 |  34.672 ns | 0.0624 ns | 0.0584 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
     FromLongNullable | .NET Core 2.0 |   2.795 ns | 0.0130 ns | 0.0116 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |   2.824 ns | 0.0209 ns | 0.0195 ns |  1.01 |    0.01 |      - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |   2.826 ns | 0.0086 ns | 0.0081 ns |  1.01 |    0.01 |      - |     - |     - |         - |
     FromLongNullable |        net461 |   2.646 ns | 0.0085 ns | 0.0079 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     FromLongNullable |        net472 |   2.935 ns | 0.0138 ns | 0.0129 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
            FromULong | .NET Core 2.0 |  31.489 ns | 0.1582 ns | 0.1480 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromULong | .NET Core 2.2 |  20.015 ns | 0.0507 ns | 0.0450 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromULong | .NET Core 3.0 |  12.700 ns | 0.0196 ns | 0.0153 ns |  0.40 |    0.00 |      - |     - |     - |         - |
            FromULong |        net461 |  33.123 ns | 0.0869 ns | 0.0813 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromULong |        net472 |  33.947 ns | 0.2824 ns | 0.2642 ns |  1.08 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
    FromULongNullable | .NET Core 2.0 |   2.909 ns | 0.0205 ns | 0.0182 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |   2.610 ns | 0.0081 ns | 0.0072 ns |  0.90 |    0.01 |      - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |   2.986 ns | 0.0194 ns | 0.0181 ns |  1.03 |    0.01 |      - |     - |     - |         - |
    FromULongNullable |        net461 |   2.972 ns | 0.0126 ns | 0.0118 ns |  1.02 |    0.01 |      - |     - |     - |         - |
    FromULongNullable |        net472 |   2.731 ns | 0.0109 ns | 0.0096 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
            FromFloat | .NET Core 2.0 |  97.905 ns | 0.1565 ns | 0.1307 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
            FromFloat | .NET Core 2.2 |  42.482 ns | 0.0486 ns | 0.0405 ns |  0.43 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromFloat | .NET Core 3.0 |  52.096 ns | 0.2599 ns | 0.2431 ns |  0.53 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromFloat |        net461 |  97.629 ns | 0.1656 ns | 0.1468 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
            FromFloat |        net472 |  97.325 ns | 0.1477 ns | 0.1382 ns |  0.99 |    0.00 | 0.0050 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
    FromFloatNullable | .NET Core 2.0 |   2.331 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |   2.322 ns | 0.0049 ns | 0.0044 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |   2.239 ns | 0.0055 ns | 0.0043 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable |        net461 |   2.463 ns | 0.0073 ns | 0.0069 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable |        net472 |   2.332 ns | 0.0093 ns | 0.0087 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
           FromDouble | .NET Core 2.0 | 111.932 ns | 0.1549 ns | 0.1373 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
           FromDouble | .NET Core 2.2 |  42.141 ns | 0.0966 ns | 0.0857 ns |  0.38 |    0.00 | 0.0051 |     - |     - |      32 B |
           FromDouble | .NET Core 3.0 |  51.845 ns | 0.2945 ns | 0.2755 ns |  0.46 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromDouble |        net461 | 104.485 ns | 0.1648 ns | 0.1377 ns |  0.93 |    0.00 | 0.0050 |     - |     - |      32 B |
           FromDouble |        net472 | 104.601 ns | 0.6535 ns | 0.6113 ns |  0.93 |    0.01 | 0.0050 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |   2.867 ns | 0.0124 ns | 0.0104 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |   2.821 ns | 0.0114 ns | 0.0095 ns |  0.98 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |   2.781 ns | 0.0090 ns | 0.0080 ns |  0.97 |    0.01 |      - |     - |     - |         - |
   FromDoubleNullable |        net461 |   3.216 ns | 0.0240 ns | 0.0224 ns |  1.12 |    0.01 |      - |     - |     - |         - |
   FromDoubleNullable |        net472 |   2.839 ns | 0.0402 ns | 0.0357 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
          FromDecimal | .NET Core 2.0 |  54.094 ns | 0.2044 ns | 0.1912 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 2.2 |  47.999 ns | 0.2659 ns | 0.2357 ns |  0.89 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 3.0 |  48.237 ns | 0.1149 ns | 0.1019 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
          FromDecimal |        net461 |  49.577 ns | 0.1582 ns | 0.1402 ns |  0.92 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal |        net472 |  51.497 ns | 0.2486 ns | 0.2204 ns |  0.95 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  11.559 ns | 0.0451 ns | 0.0422 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |   9.444 ns | 0.0366 ns | 0.0325 ns |  0.82 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |   9.456 ns | 0.0626 ns | 0.0586 ns |  0.82 |    0.01 |      - |     - |     - |         - |
  FromDecimalNullable |        net461 |  13.056 ns | 0.0228 ns | 0.0191 ns |  1.13 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable |        net472 |   9.272 ns | 0.0209 ns | 0.0186 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
         FromDateTime | .NET Core 2.0 | 320.177 ns | 1.2359 ns | 1.0956 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
         FromDateTime | .NET Core 2.2 | 278.464 ns | 0.4747 ns | 0.4441 ns |  0.87 |    0.00 | 0.0262 |     - |     - |     168 B |
         FromDateTime | .NET Core 3.0 | 225.802 ns | 1.7941 ns | 1.6782 ns |  0.70 |    0.01 | 0.0100 |     - |     - |      64 B |
         FromDateTime |        net461 | 324.791 ns | 0.5509 ns | 0.5153 ns |  1.01 |    0.00 | 0.0300 |     - |     - |     192 B |
         FromDateTime |        net472 | 326.814 ns | 1.6247 ns | 1.3567 ns |  1.02 |    0.01 | 0.0300 |     - |     - |     192 B |
                      |               |            |           |           |       |         |        |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |   3.053 ns | 0.0199 ns | 0.0186 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |   2.762 ns | 0.0178 ns | 0.0166 ns |  0.90 |    0.01 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |   3.059 ns | 0.0259 ns | 0.0242 ns |  1.00 |    0.01 |      - |     - |     - |         - |
 FromDateTimeNullable |        net461 |   3.333 ns | 0.0087 ns | 0.0081 ns |  1.09 |    0.01 |      - |     - |     - |         - |
 FromDateTimeNullable |        net472 |   3.074 ns | 0.0101 ns | 0.0090 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
           FromObject | .NET Core 2.0 |   2.659 ns | 0.0116 ns | 0.0097 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 2.2 |   2.204 ns | 0.0039 ns | 0.0032 ns |  0.83 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 3.0 |   2.056 ns | 0.0182 ns | 0.0170 ns |  0.77 |    0.01 |      - |     - |     - |         - |
           FromObject |        net461 |   3.309 ns | 0.0363 ns | 0.0340 ns |  1.24 |    0.01 |      - |     - |     - |         - |
           FromObject |        net472 |   3.081 ns | 0.0057 ns | 0.0054 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
           FromString | .NET Core 2.0 |   1.868 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 2.2 |   1.896 ns | 0.0045 ns | 0.0043 ns |  1.01 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 3.0 |   1.542 ns | 0.0102 ns | 0.0095 ns |  0.83 |    0.00 |      - |     - |     - |         - |
           FromString |        net461 |   2.118 ns | 0.0046 ns | 0.0040 ns |  1.13 |    0.00 |      - |     - |     - |         - |
           FromString |        net472 |   1.846 ns | 0.0052 ns | 0.0044 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
             FromEnum | .NET Core 2.0 | 105.641 ns | 0.4914 ns | 0.4103 ns |  1.00 |    0.00 | 0.0126 |     - |     - |      80 B |
             FromEnum | .NET Core 2.2 |  69.779 ns | 0.1643 ns | 0.1372 ns |  0.66 |    0.00 | 0.0126 |     - |     - |      80 B |
             FromEnum | .NET Core 3.0 |  49.128 ns | 0.1054 ns | 0.0934 ns |  0.47 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromEnum |        net461 | 342.962 ns | 0.8287 ns | 0.6920 ns |  3.25 |    0.01 | 0.0162 |     - |     - |     104 B |
             FromEnum |        net472 | 345.685 ns | 1.6637 ns | 1.4748 ns |  3.27 |    0.02 | 0.0162 |     - |     - |     104 B |
                      |               |            |           |           |       |         |        |       |       |           |
     FromEnumNullable | .NET Core 2.0 |   2.578 ns | 0.0119 ns | 0.0112 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |   2.447 ns | 0.0140 ns | 0.0131 ns |  0.95 |    0.01 |      - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |   1.950 ns | 0.0030 ns | 0.0028 ns |  0.76 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable |        net461 |   2.327 ns | 0.0080 ns | 0.0071 ns |  0.90 |    0.01 |      - |     - |     - |         - |
     FromEnumNullable |        net472 |   2.705 ns | 0.0051 ns | 0.0048 ns |  1.05 |    0.00 |      - |     - |     - |         - |
