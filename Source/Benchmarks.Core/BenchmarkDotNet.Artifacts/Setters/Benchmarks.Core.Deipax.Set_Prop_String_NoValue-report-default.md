
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
             FromBool | .NET Core 2.0 |   3.498 ns | 0.0075 ns | 0.0066 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromBool | .NET Core 2.2 |   3.489 ns | 0.0148 ns | 0.0124 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromBool | .NET Core 3.0 |   3.529 ns | 0.0113 ns | 0.0100 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             FromBool |        net461 |   4.226 ns | 0.0077 ns | 0.0060 ns |  1.21 |    0.00 |      - |     - |     - |         - |
             FromBool |        net472 |   3.612 ns | 0.0306 ns | 0.0286 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
     FromBoolNullable | .NET Core 2.0 |   2.226 ns | 0.0091 ns | 0.0085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |   1.845 ns | 0.0197 ns | 0.0184 ns |  0.83 |    0.01 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |   1.979 ns | 0.0063 ns | 0.0056 ns |  0.89 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable |        net461 |   2.271 ns | 0.0046 ns | 0.0043 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable |        net472 |   2.007 ns | 0.0205 ns | 0.0191 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
             FromChar | .NET Core 2.0 |   4.990 ns | 0.0112 ns | 0.0087 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromChar | .NET Core 2.2 |   4.835 ns | 0.0143 ns | 0.0111 ns |  0.97 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromChar | .NET Core 3.0 |   4.461 ns | 0.0365 ns | 0.0341 ns |  0.89 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromChar |        net461 |   7.176 ns | 0.0507 ns | 0.0474 ns |  1.44 |    0.01 | 0.0051 |     - |     - |      32 B |
             FromChar |        net472 |   6.998 ns | 0.0255 ns | 0.0226 ns |  1.40 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
     FromCharNullable | .NET Core 2.0 |   2.359 ns | 0.0097 ns | 0.0091 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |   1.911 ns | 0.0039 ns | 0.0034 ns |  0.81 |    0.00 |      - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |   2.084 ns | 0.0062 ns | 0.0055 ns |  0.88 |    0.00 |      - |     - |     - |         - |
     FromCharNullable |        net461 |   2.350 ns | 0.0069 ns | 0.0065 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromCharNullable |        net472 |   3.121 ns | 0.0055 ns | 0.0049 ns |  1.32 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
            FromSByte | .NET Core 2.0 |  30.121 ns | 0.1690 ns | 0.1581 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromSByte | .NET Core 2.2 |  18.191 ns | 0.0291 ns | 0.0258 ns |  0.60 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromSByte | .NET Core 3.0 |  14.368 ns | 0.0276 ns | 0.0216 ns |  0.48 |    0.00 |      - |     - |     - |         - |
            FromSByte |        net461 |  33.472 ns | 0.1608 ns | 0.1504 ns |  1.11 |    0.01 | 0.0051 |     - |     - |      32 B |
            FromSByte |        net472 |  33.548 ns | 0.0845 ns | 0.0791 ns |  1.11 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
    FromSByteNullable | .NET Core 2.0 |   2.166 ns | 0.0066 ns | 0.0062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |   2.471 ns | 0.0059 ns | 0.0052 ns |  1.14 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |   2.044 ns | 0.0043 ns | 0.0040 ns |  0.94 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable |        net461 |   2.390 ns | 0.0121 ns | 0.0107 ns |  1.10 |    0.01 |      - |     - |     - |         - |
    FromSByteNullable |        net472 |   2.049 ns | 0.0039 ns | 0.0037 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
             FromByte | .NET Core 2.0 |  29.863 ns | 0.0963 ns | 0.0853 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromByte | .NET Core 2.2 |  18.121 ns | 0.0709 ns | 0.0592 ns |  0.61 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromByte | .NET Core 3.0 |  12.778 ns | 0.2777 ns | 0.2852 ns |  0.43 |    0.01 |      - |     - |     - |         - |
             FromByte |        net461 |  33.738 ns | 0.0673 ns | 0.0629 ns |  1.13 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromByte |        net472 |  33.651 ns | 0.3087 ns | 0.2888 ns |  1.13 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
     FromByteNullable | .NET Core 2.0 |   2.411 ns | 0.0129 ns | 0.0114 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |   2.116 ns | 0.0078 ns | 0.0061 ns |  0.88 |    0.00 |      - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |   1.979 ns | 0.0031 ns | 0.0029 ns |  0.82 |    0.00 |      - |     - |     - |         - |
     FromByteNullable |        net461 |   2.883 ns | 0.0231 ns | 0.0216 ns |  1.19 |    0.01 |      - |     - |     - |         - |
     FromByteNullable |        net472 |   2.452 ns | 0.0092 ns | 0.0081 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
            FromShort | .NET Core 2.0 |  29.792 ns | 0.1311 ns | 0.1162 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromShort | .NET Core 2.2 |  18.203 ns | 0.0891 ns | 0.0833 ns |  0.61 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromShort | .NET Core 3.0 |  13.535 ns | 0.0333 ns | 0.0295 ns |  0.45 |    0.00 |      - |     - |     - |         - |
            FromShort |        net461 |  33.753 ns | 0.1755 ns | 0.1642 ns |  1.13 |    0.01 | 0.0051 |     - |     - |      32 B |
            FromShort |        net472 |  33.298 ns | 0.2755 ns | 0.2577 ns |  1.12 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
    FromShortNullable | .NET Core 2.0 |   2.122 ns | 0.0095 ns | 0.0084 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |   2.092 ns | 0.0031 ns | 0.0026 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |   2.201 ns | 0.0063 ns | 0.0059 ns |  1.04 |    0.01 |      - |     - |     - |         - |
    FromShortNullable |        net461 |   2.383 ns | 0.0117 ns | 0.0109 ns |  1.12 |    0.01 |      - |     - |     - |         - |
    FromShortNullable |        net472 |   2.104 ns | 0.0095 ns | 0.0089 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
           FromUShort | .NET Core 2.0 |  26.977 ns | 0.0621 ns | 0.0551 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
           FromUShort | .NET Core 2.2 |  17.881 ns | 0.0424 ns | 0.0396 ns |  0.66 |    0.00 | 0.0051 |     - |     - |      32 B |
           FromUShort | .NET Core 3.0 |  12.973 ns | 0.2234 ns | 0.2090 ns |  0.48 |    0.01 |      - |     - |     - |         - |
           FromUShort |        net461 |  32.058 ns | 0.0996 ns | 0.0883 ns |  1.19 |    0.00 | 0.0051 |     - |     - |      32 B |
           FromUShort |        net472 |  32.464 ns | 0.1086 ns | 0.0963 ns |  1.20 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
   FromUShortNullable | .NET Core 2.0 |   2.416 ns | 0.0177 ns | 0.0165 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |   2.332 ns | 0.0136 ns | 0.0127 ns |  0.96 |    0.01 |      - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |   2.242 ns | 0.0046 ns | 0.0043 ns |  0.93 |    0.01 |      - |     - |     - |         - |
   FromUShortNullable |        net461 |   2.981 ns | 0.0206 ns | 0.0172 ns |  1.23 |    0.01 |      - |     - |     - |         - |
   FromUShortNullable |        net472 |   2.506 ns | 0.0093 ns | 0.0087 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
              FromInt | .NET Core 2.0 |  29.814 ns | 0.1736 ns | 0.1539 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
              FromInt | .NET Core 2.2 |  18.205 ns | 0.1128 ns | 0.1055 ns |  0.61 |    0.00 | 0.0051 |     - |     - |      32 B |
              FromInt | .NET Core 3.0 |  13.012 ns | 0.0298 ns | 0.0249 ns |  0.44 |    0.00 |      - |     - |     - |         - |
              FromInt |        net461 |  32.310 ns | 0.0450 ns | 0.0399 ns |  1.08 |    0.01 | 0.0051 |     - |     - |      32 B |
              FromInt |        net472 |  33.224 ns | 0.0788 ns | 0.0658 ns |  1.11 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
      FromIntNullable | .NET Core 2.0 |   2.108 ns | 0.0050 ns | 0.0047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |   2.081 ns | 0.0116 ns | 0.0097 ns |  0.99 |    0.00 |      - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |   2.245 ns | 0.0056 ns | 0.0047 ns |  1.06 |    0.00 |      - |     - |     - |         - |
      FromIntNullable |        net461 |   2.185 ns | 0.0063 ns | 0.0059 ns |  1.04 |    0.00 |      - |     - |     - |         - |
      FromIntNullable |        net472 |   2.053 ns | 0.0051 ns | 0.0040 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
             FromUInt | .NET Core 2.0 |  27.548 ns | 0.1012 ns | 0.0947 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromUInt | .NET Core 2.2 |  18.118 ns | 0.1098 ns | 0.1027 ns |  0.66 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromUInt | .NET Core 3.0 |  12.582 ns | 0.0210 ns | 0.0197 ns |  0.46 |    0.00 |      - |     - |     - |         - |
             FromUInt |        net461 |  31.855 ns | 0.2105 ns | 0.1969 ns |  1.16 |    0.01 | 0.0051 |     - |     - |      32 B |
             FromUInt |        net472 |  32.432 ns | 0.1280 ns | 0.1197 ns |  1.18 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
     FromUIntNullable | .NET Core 2.0 |   2.569 ns | 0.0155 ns | 0.0138 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |   2.106 ns | 0.0062 ns | 0.0058 ns |  0.82 |    0.01 |      - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |   2.239 ns | 0.0058 ns | 0.0051 ns |  0.87 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable |        net461 |   2.838 ns | 0.0099 ns | 0.0088 ns |  1.10 |    0.01 |      - |     - |     - |         - |
     FromUIntNullable |        net472 |   2.336 ns | 0.0072 ns | 0.0064 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
             FromLong | .NET Core 2.0 |  33.706 ns | 0.0895 ns | 0.0838 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromLong | .NET Core 2.2 |  20.087 ns | 0.1705 ns | 0.1512 ns |  0.60 |    0.01 | 0.0051 |     - |     - |      32 B |
             FromLong | .NET Core 3.0 |  13.329 ns | 0.0508 ns | 0.0424 ns |  0.40 |    0.00 |      - |     - |     - |         - |
             FromLong |        net461 |  33.812 ns | 0.1061 ns | 0.0992 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromLong |        net472 |  34.810 ns | 0.1728 ns | 0.1532 ns |  1.03 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
     FromLongNullable | .NET Core 2.0 |   2.779 ns | 0.0079 ns | 0.0074 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |   2.819 ns | 0.0292 ns | 0.0244 ns |  1.01 |    0.01 |      - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |   2.810 ns | 0.0085 ns | 0.0079 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     FromLongNullable |        net461 |   3.264 ns | 0.0310 ns | 0.0290 ns |  1.17 |    0.01 |      - |     - |     - |         - |
     FromLongNullable |        net472 |   2.930 ns | 0.0122 ns | 0.0102 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
            FromULong | .NET Core 2.0 |  31.941 ns | 0.0879 ns | 0.0780 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromULong | .NET Core 2.2 |  20.030 ns | 0.0644 ns | 0.0602 ns |  0.63 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromULong | .NET Core 3.0 |  12.621 ns | 0.1631 ns | 0.1526 ns |  0.40 |    0.00 |      - |     - |     - |         - |
            FromULong |        net461 |  32.946 ns | 0.2489 ns | 0.2328 ns |  1.03 |    0.01 | 0.0051 |     - |     - |      32 B |
            FromULong |        net472 |  33.948 ns | 0.2264 ns | 0.2118 ns |  1.06 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
    FromULongNullable | .NET Core 2.0 |   2.909 ns | 0.0099 ns | 0.0088 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |   2.605 ns | 0.0057 ns | 0.0051 ns |  0.90 |    0.00 |      - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |   3.000 ns | 0.0237 ns | 0.0221 ns |  1.03 |    0.01 |      - |     - |     - |         - |
    FromULongNullable |        net461 |   2.968 ns | 0.0060 ns | 0.0050 ns |  1.02 |    0.00 |      - |     - |     - |         - |
    FromULongNullable |        net472 |   2.730 ns | 0.0063 ns | 0.0059 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
            FromFloat | .NET Core 2.0 |  97.804 ns | 0.1811 ns | 0.1414 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
            FromFloat | .NET Core 2.2 |  42.246 ns | 0.1311 ns | 0.1162 ns |  0.43 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromFloat | .NET Core 3.0 |  52.158 ns | 0.0922 ns | 0.0862 ns |  0.53 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromFloat |        net461 |  97.902 ns | 0.1383 ns | 0.1226 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
            FromFloat |        net472 |  97.644 ns | 0.1925 ns | 0.1608 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
    FromFloatNullable | .NET Core 2.0 |   2.331 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |   2.322 ns | 0.0059 ns | 0.0055 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |   2.238 ns | 0.0059 ns | 0.0055 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable |        net461 |   2.452 ns | 0.0082 ns | 0.0069 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable |        net472 |   2.329 ns | 0.0103 ns | 0.0092 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
           FromDouble | .NET Core 2.0 | 107.989 ns | 0.1922 ns | 0.1605 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
           FromDouble | .NET Core 2.2 |  42.005 ns | 0.1058 ns | 0.0938 ns |  0.39 |    0.00 | 0.0051 |     - |     - |      32 B |
           FromDouble | .NET Core 3.0 |  51.273 ns | 0.1080 ns | 0.0958 ns |  0.47 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromDouble |        net461 | 105.163 ns | 0.6393 ns | 0.5980 ns |  0.97 |    0.01 | 0.0050 |     - |     - |      32 B |
           FromDouble |        net472 | 104.104 ns | 0.1755 ns | 0.1642 ns |  0.96 |    0.00 | 0.0050 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |   3.018 ns | 0.0065 ns | 0.0055 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |   2.829 ns | 0.0262 ns | 0.0232 ns |  0.94 |    0.01 |      - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |   2.798 ns | 0.0186 ns | 0.0174 ns |  0.93 |    0.01 |      - |     - |     - |         - |
   FromDoubleNullable |        net461 |   3.189 ns | 0.0092 ns | 0.0082 ns |  1.06 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable |        net472 |   2.872 ns | 0.0273 ns | 0.0255 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
          FromDecimal | .NET Core 2.0 |  53.644 ns | 0.1007 ns | 0.0893 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 2.2 |  47.950 ns | 0.2101 ns | 0.1965 ns |  0.89 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 3.0 |  48.093 ns | 0.1122 ns | 0.1049 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
          FromDecimal |        net461 |  51.995 ns | 0.1253 ns | 0.1111 ns |  0.97 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal |        net472 |  50.828 ns | 0.0988 ns | 0.0771 ns |  0.95 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  11.524 ns | 0.0306 ns | 0.0286 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |   9.364 ns | 0.0959 ns | 0.0897 ns |  0.81 |    0.01 |      - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |   9.493 ns | 0.0263 ns | 0.0233 ns |  0.82 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable |        net461 |  13.062 ns | 0.0282 ns | 0.0264 ns |  1.13 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable |        net472 |   9.276 ns | 0.0144 ns | 0.0135 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
         FromDateTime | .NET Core 2.0 | 334.933 ns | 1.7987 ns | 1.6825 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
         FromDateTime | .NET Core 2.2 | 277.900 ns | 0.8366 ns | 0.7826 ns |  0.83 |    0.00 | 0.0262 |     - |     - |     168 B |
         FromDateTime | .NET Core 3.0 | 224.425 ns | 0.7794 ns | 0.7291 ns |  0.67 |    0.00 | 0.0100 |     - |     - |      64 B |
         FromDateTime |        net461 | 324.996 ns | 0.9594 ns | 0.8011 ns |  0.97 |    0.00 | 0.0300 |     - |     - |     192 B |
         FromDateTime |        net472 | 331.565 ns | 0.9755 ns | 0.8648 ns |  0.99 |    0.01 | 0.0300 |     - |     - |     192 B |
                      |               |            |           |           |       |         |        |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |   2.874 ns | 0.0072 ns | 0.0060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |   2.736 ns | 0.0185 ns | 0.0173 ns |  0.95 |    0.01 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |   3.062 ns | 0.0075 ns | 0.0059 ns |  1.07 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable |        net461 |   3.373 ns | 0.0084 ns | 0.0078 ns |  1.17 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable |        net472 |   3.717 ns | 0.0062 ns | 0.0055 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
           FromObject | .NET Core 2.0 |   2.951 ns | 0.0109 ns | 0.0102 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 2.2 |   2.915 ns | 0.0167 ns | 0.0148 ns |  0.99 |    0.01 |      - |     - |     - |         - |
           FromObject | .NET Core 3.0 |   2.471 ns | 0.0090 ns | 0.0075 ns |  0.84 |    0.00 |      - |     - |     - |         - |
           FromObject |        net461 |   3.281 ns | 0.0125 ns | 0.0111 ns |  1.11 |    0.01 |      - |     - |     - |         - |
           FromObject |        net472 |   3.041 ns | 0.0369 ns | 0.0345 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
           FromString | .NET Core 2.0 |   1.866 ns | 0.0049 ns | 0.0044 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 2.2 |   1.903 ns | 0.0209 ns | 0.0196 ns |  1.02 |    0.01 |      - |     - |     - |         - |
           FromString | .NET Core 3.0 |   1.536 ns | 0.0056 ns | 0.0053 ns |  0.82 |    0.00 |      - |     - |     - |         - |
           FromString |        net461 |   2.133 ns | 0.0181 ns | 0.0169 ns |  1.14 |    0.01 |      - |     - |     - |         - |
           FromString |        net472 |   1.846 ns | 0.0065 ns | 0.0061 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
             FromEnum | .NET Core 2.0 | 104.091 ns | 0.2948 ns | 0.2613 ns |  1.00 |    0.00 | 0.0126 |     - |     - |      80 B |
             FromEnum | .NET Core 2.2 |  70.045 ns | 0.5808 ns | 0.5433 ns |  0.67 |    0.00 | 0.0126 |     - |     - |      80 B |
             FromEnum | .NET Core 3.0 |  49.091 ns | 0.0860 ns | 0.0718 ns |  0.47 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromEnum |        net461 | 347.997 ns | 0.8889 ns | 0.8315 ns |  3.34 |    0.01 | 0.0162 |     - |     - |     104 B |
             FromEnum |        net472 | 346.871 ns | 2.6946 ns | 2.5206 ns |  3.33 |    0.02 | 0.0162 |     - |     - |     104 B |
                      |               |            |           |           |       |         |        |       |       |           |
     FromEnumNullable | .NET Core 2.0 |   2.566 ns | 0.0079 ns | 0.0066 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |   2.510 ns | 0.0104 ns | 0.0097 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |   1.944 ns | 0.0053 ns | 0.0047 ns |  0.76 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable |        net461 |   2.455 ns | 0.0206 ns | 0.0193 ns |  0.96 |    0.01 |      - |     - |     - |         - |
     FromEnumNullable |        net472 |   2.060 ns | 0.0094 ns | 0.0084 ns |  0.80 |    0.00 |      - |     - |     - |         - |
