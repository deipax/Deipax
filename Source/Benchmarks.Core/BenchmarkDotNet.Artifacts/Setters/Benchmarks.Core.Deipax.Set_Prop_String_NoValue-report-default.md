
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EESCLK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-QSSVGP : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EOYUJY : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-ETYLEW : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-VJGCOH : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |   3.449 ns | 0.0083 ns | 0.0073 ns |   3.447 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromBool | .NET Core 2.2 |   3.661 ns | 0.0110 ns | 0.0098 ns |   3.661 ns |  1.06 |    0.00 |      - |     - |     - |         - |
             FromBool | .NET Core 3.0 |   3.501 ns | 0.0113 ns | 0.0106 ns |   3.503 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             FromBool |        net461 |   3.658 ns | 0.0112 ns | 0.0099 ns |   3.657 ns |  1.06 |    0.00 |      - |     - |     - |         - |
             FromBool |        net472 |   3.655 ns | 0.0130 ns | 0.0115 ns |   3.655 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
     FromBoolNullable | .NET Core 2.0 |   2.208 ns | 0.0056 ns | 0.0053 ns |   2.209 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |   2.095 ns | 0.0046 ns | 0.0043 ns |   2.096 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |   2.056 ns | 0.0162 ns | 0.0151 ns |   2.049 ns |  0.93 |    0.01 |      - |     - |     - |         - |
     FromBoolNullable |        net461 |   1.998 ns | 0.0026 ns | 0.0024 ns |   1.998 ns |  0.90 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable |        net472 |   2.017 ns | 0.0277 ns | 0.0259 ns |   2.000 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
             FromChar | .NET Core 2.0 |   4.965 ns | 0.0093 ns | 0.0073 ns |   4.964 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromChar | .NET Core 2.2 |   4.895 ns | 0.0097 ns | 0.0090 ns |   4.894 ns |  0.99 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromChar | .NET Core 3.0 |   4.926 ns | 0.0191 ns | 0.0179 ns |   4.927 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromChar |        net461 |   6.671 ns | 0.0329 ns | 0.0308 ns |   6.677 ns |  1.34 |    0.01 | 0.0051 |     - |     - |      32 B |
             FromChar |        net472 |   6.727 ns | 0.0284 ns | 0.0237 ns |   6.727 ns |  1.35 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
     FromCharNullable | .NET Core 2.0 |   2.343 ns | 0.0048 ns | 0.0045 ns |   2.343 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |   2.411 ns | 0.0059 ns | 0.0053 ns |   2.410 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |   2.017 ns | 0.0072 ns | 0.0067 ns |   2.018 ns |  0.86 |    0.00 |      - |     - |     - |         - |
     FromCharNullable |        net461 |   2.033 ns | 0.0063 ns | 0.0059 ns |   2.033 ns |  0.87 |    0.00 |      - |     - |     - |         - |
     FromCharNullable |        net472 |   2.035 ns | 0.0058 ns | 0.0055 ns |   2.035 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
            FromSByte | .NET Core 2.0 |  29.532 ns | 0.0521 ns | 0.0487 ns |  29.530 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromSByte | .NET Core 2.2 |  18.150 ns | 0.0333 ns | 0.0312 ns |  18.148 ns |  0.61 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromSByte | .NET Core 3.0 |  14.155 ns | 0.0541 ns | 0.0506 ns |  14.176 ns |  0.48 |    0.00 |      - |     - |     - |         - |
            FromSByte |        net461 |  32.405 ns | 0.0604 ns | 0.0565 ns |  32.385 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromSByte |        net472 |  34.713 ns | 0.1906 ns | 0.1690 ns |  34.792 ns |  1.18 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
    FromSByteNullable | .NET Core 2.0 |   2.135 ns | 0.0150 ns | 0.0140 ns |   2.140 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |   2.195 ns | 0.0058 ns | 0.0054 ns |   2.195 ns |  1.03 |    0.01 |      - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |   1.959 ns | 0.0045 ns | 0.0042 ns |   1.959 ns |  0.92 |    0.01 |      - |     - |     - |         - |
    FromSByteNullable |        net461 |   2.175 ns | 0.0056 ns | 0.0047 ns |   2.175 ns |  1.02 |    0.01 |      - |     - |     - |         - |
    FromSByteNullable |        net472 |   2.182 ns | 0.0080 ns | 0.0075 ns |   2.180 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
             FromByte | .NET Core 2.0 |  29.945 ns | 0.0538 ns | 0.0503 ns |  29.946 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromByte | .NET Core 2.2 |  17.965 ns | 0.1071 ns | 0.0895 ns |  17.951 ns |  0.60 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromByte | .NET Core 3.0 |  13.297 ns | 0.1172 ns | 0.1096 ns |  13.342 ns |  0.44 |    0.00 |      - |     - |     - |         - |
             FromByte |        net461 |  32.893 ns | 0.0557 ns | 0.0521 ns |  32.901 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromByte |        net472 |  33.190 ns | 0.0483 ns | 0.0428 ns |  33.188 ns |  1.11 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
     FromByteNullable | .NET Core 2.0 |   2.320 ns | 0.0049 ns | 0.0043 ns |   2.320 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |   2.346 ns | 0.0073 ns | 0.0068 ns |   2.348 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |   2.063 ns | 0.0130 ns | 0.0121 ns |   2.068 ns |  0.89 |    0.01 |      - |     - |     - |         - |
     FromByteNullable |        net461 |   2.658 ns | 0.0190 ns | 0.0178 ns |   2.653 ns |  1.15 |    0.01 |      - |     - |     - |         - |
     FromByteNullable |        net472 |   2.752 ns | 0.0159 ns | 0.0149 ns |   2.756 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
            FromShort | .NET Core 2.0 |  30.508 ns | 0.1337 ns | 0.1185 ns |  30.483 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromShort | .NET Core 2.2 |  18.105 ns | 0.0571 ns | 0.0534 ns |  18.100 ns |  0.59 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromShort | .NET Core 3.0 |  13.317 ns | 0.0312 ns | 0.0261 ns |  13.309 ns |  0.44 |    0.00 |      - |     - |     - |         - |
            FromShort |        net461 |  32.542 ns | 0.1033 ns | 0.0915 ns |  32.526 ns |  1.07 |    0.01 | 0.0051 |     - |     - |      32 B |
            FromShort |        net472 |  32.657 ns | 0.0474 ns | 0.0444 ns |  32.667 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
    FromShortNullable | .NET Core 2.0 |   2.078 ns | 0.0042 ns | 0.0037 ns |   2.079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |   2.358 ns | 0.0052 ns | 0.0049 ns |   2.357 ns |  1.13 |    0.00 |      - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |   2.227 ns | 0.0111 ns | 0.0104 ns |   2.231 ns |  1.07 |    0.01 |      - |     - |     - |         - |
    FromShortNullable |        net461 |   2.365 ns | 0.0052 ns | 0.0049 ns |   2.364 ns |  1.14 |    0.00 |      - |     - |     - |         - |
    FromShortNullable |        net472 |   2.364 ns | 0.0070 ns | 0.0059 ns |   2.365 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
           FromUShort | .NET Core 2.0 |  26.745 ns | 0.0917 ns | 0.0766 ns |  26.730 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
           FromUShort | .NET Core 2.2 |  17.710 ns | 0.0727 ns | 0.0645 ns |  17.687 ns |  0.66 |    0.00 | 0.0051 |     - |     - |      32 B |
           FromUShort | .NET Core 3.0 |  13.140 ns | 0.0255 ns | 0.0239 ns |  13.129 ns |  0.49 |    0.00 |      - |     - |     - |         - |
           FromUShort |        net461 |  31.525 ns | 0.1309 ns | 0.1225 ns |  31.489 ns |  1.18 |    0.01 | 0.0051 |     - |     - |      32 B |
           FromUShort |        net472 |  31.748 ns | 0.0358 ns | 0.0299 ns |  31.756 ns |  1.19 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
   FromUShortNullable | .NET Core 2.0 |   2.301 ns | 0.0035 ns | 0.0029 ns |   2.301 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |   2.072 ns | 0.0169 ns | 0.0158 ns |   2.064 ns |  0.90 |    0.01 |      - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |   2.185 ns | 0.0022 ns | 0.0021 ns |   2.186 ns |  0.95 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable |        net461 |   2.556 ns | 0.0068 ns | 0.0057 ns |   2.557 ns |  1.11 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable |        net472 |   2.545 ns | 0.0077 ns | 0.0065 ns |   2.547 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
              FromInt | .NET Core 2.0 |  29.340 ns | 0.0690 ns | 0.0612 ns |  29.347 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
              FromInt | .NET Core 2.2 |  18.141 ns | 0.0316 ns | 0.0281 ns |  18.143 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
              FromInt | .NET Core 3.0 |  12.968 ns | 0.0981 ns | 0.0917 ns |  12.991 ns |  0.44 |    0.00 |      - |     - |     - |         - |
              FromInt |        net461 |  31.773 ns | 0.0952 ns | 0.0891 ns |  31.753 ns |  1.08 |    0.00 | 0.0051 |     - |     - |      32 B |
              FromInt |        net472 |  32.155 ns | 0.0787 ns | 0.0697 ns |  32.147 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
      FromIntNullable | .NET Core 2.0 |   2.077 ns | 0.0029 ns | 0.0027 ns |   2.077 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |   2.324 ns | 0.0086 ns | 0.0080 ns |   2.325 ns |  1.12 |    0.00 |      - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |   2.184 ns | 0.0044 ns | 0.0037 ns |   2.184 ns |  1.05 |    0.00 |      - |     - |     - |         - |
      FromIntNullable |        net461 |   2.008 ns | 0.0029 ns | 0.0025 ns |   2.008 ns |  0.97 |    0.00 |      - |     - |     - |         - |
      FromIntNullable |        net472 |   2.006 ns | 0.0035 ns | 0.0031 ns |   2.006 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
             FromUInt | .NET Core 2.0 |  26.774 ns | 0.0746 ns | 0.0698 ns |  26.762 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromUInt | .NET Core 2.2 |  17.730 ns | 0.0478 ns | 0.0423 ns |  17.732 ns |  0.66 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromUInt | .NET Core 3.0 |  12.393 ns | 0.0330 ns | 0.0309 ns |  12.395 ns |  0.46 |    0.00 |      - |     - |     - |         - |
             FromUInt |        net461 |  30.853 ns | 0.0522 ns | 0.0436 ns |  30.840 ns |  1.15 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromUInt |        net472 |  31.491 ns | 0.0621 ns | 0.0581 ns |  31.490 ns |  1.18 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
     FromUIntNullable | .NET Core 2.0 |   2.533 ns | 0.0038 ns | 0.0035 ns |   2.533 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |   2.049 ns | 0.0078 ns | 0.0065 ns |   2.051 ns |  0.81 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |   2.571 ns | 0.0061 ns | 0.0057 ns |   2.570 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable |        net461 |   2.358 ns | 0.0152 ns | 0.0142 ns |   2.363 ns |  0.93 |    0.01 |      - |     - |     - |         - |
     FromUIntNullable |        net472 |   2.294 ns | 0.0063 ns | 0.0059 ns |   2.295 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
             FromLong | .NET Core 2.0 |  32.084 ns | 0.0630 ns | 0.0558 ns |  32.070 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromLong | .NET Core 2.2 |  19.341 ns | 0.0304 ns | 0.0270 ns |  19.343 ns |  0.60 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromLong | .NET Core 3.0 |  13.150 ns | 0.0120 ns | 0.0112 ns |  13.148 ns |  0.41 |    0.00 |      - |     - |     - |         - |
             FromLong |        net461 |  33.534 ns | 0.0394 ns | 0.0349 ns |  33.528 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromLong |        net472 |  34.252 ns | 0.1091 ns | 0.0967 ns |  34.223 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
     FromLongNullable | .NET Core 2.0 |   2.781 ns | 0.0067 ns | 0.0062 ns |   2.782 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |   2.747 ns | 0.0058 ns | 0.0052 ns |   2.746 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |   2.785 ns | 0.0154 ns | 0.0144 ns |   2.791 ns |  1.00 |    0.01 |      - |     - |     - |         - |
     FromLongNullable |        net461 |   2.549 ns | 0.0283 ns | 0.0265 ns |   2.536 ns |  0.92 |    0.01 |      - |     - |     - |         - |
     FromLongNullable |        net472 |   2.543 ns | 0.0214 ns | 0.0190 ns |   2.550 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
            FromULong | .NET Core 2.0 |  30.805 ns | 0.0532 ns | 0.0445 ns |  30.792 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromULong | .NET Core 2.2 |  19.639 ns | 0.0189 ns | 0.0148 ns |  19.639 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromULong | .NET Core 3.0 |  12.787 ns | 0.0213 ns | 0.0199 ns |  12.784 ns |  0.42 |    0.00 |      - |     - |     - |         - |
            FromULong |        net461 |  32.449 ns | 0.1489 ns | 0.1393 ns |  32.486 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromULong |        net472 |  32.818 ns | 0.0528 ns | 0.0468 ns |  32.818 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
    FromULongNullable | .NET Core 2.0 |   2.872 ns | 0.0102 ns | 0.0096 ns |   2.874 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |   2.540 ns | 0.0034 ns | 0.0029 ns |   2.541 ns |  0.88 |    0.00 |      - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |   2.526 ns | 0.0079 ns | 0.0074 ns |   2.525 ns |  0.88 |    0.00 |      - |     - |     - |         - |
    FromULongNullable |        net461 |   2.529 ns | 0.0061 ns | 0.0054 ns |   2.529 ns |  0.88 |    0.00 |      - |     - |     - |         - |
    FromULongNullable |        net472 |   2.549 ns | 0.0084 ns | 0.0070 ns |   2.549 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
            FromFloat | .NET Core 2.0 |  96.692 ns | 0.1622 ns | 0.1518 ns |  96.630 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
            FromFloat | .NET Core 2.2 |  41.699 ns | 0.1694 ns | 0.1501 ns |  41.722 ns |  0.43 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromFloat | .NET Core 3.0 |  51.168 ns | 0.3901 ns | 0.3649 ns |  51.099 ns |  0.53 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromFloat |        net461 |  96.816 ns | 0.0873 ns | 0.0817 ns |  96.839 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
            FromFloat |        net472 |  98.319 ns | 1.6736 ns | 1.5655 ns |  99.366 ns |  1.02 |    0.02 | 0.0050 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
    FromFloatNullable | .NET Core 2.0 |   2.318 ns | 0.0345 ns | 0.0306 ns |   2.303 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |   2.240 ns | 0.0066 ns | 0.0061 ns |   2.239 ns |  0.97 |    0.01 |      - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |   2.861 ns | 0.0702 ns | 0.0656 ns |   2.836 ns |  1.24 |    0.03 |      - |     - |     - |         - |
    FromFloatNullable |        net461 |   2.111 ns | 0.0224 ns | 0.0210 ns |   2.122 ns |  0.91 |    0.01 |      - |     - |     - |         - |
    FromFloatNullable |        net472 |   2.083 ns | 0.0103 ns | 0.0091 ns |   2.080 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
           FromDouble | .NET Core 2.0 | 110.096 ns | 0.8253 ns | 0.7720 ns | 110.233 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
           FromDouble | .NET Core 2.2 |  41.973 ns | 0.2199 ns | 0.2057 ns |  41.883 ns |  0.38 |    0.00 | 0.0051 |     - |     - |      32 B |
           FromDouble | .NET Core 3.0 |  53.370 ns | 0.1115 ns | 0.0931 ns |  53.372 ns |  0.48 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromDouble |        net461 | 103.526 ns | 0.1160 ns | 0.1029 ns | 103.520 ns |  0.94 |    0.01 | 0.0050 |     - |     - |      32 B |
           FromDouble |        net472 | 102.753 ns | 0.1409 ns | 0.1318 ns | 102.719 ns |  0.93 |    0.01 | 0.0050 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |   2.865 ns | 0.0138 ns | 0.0122 ns |   2.868 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |   2.804 ns | 0.0051 ns | 0.0045 ns |   2.803 ns |  0.98 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |   2.528 ns | 0.0864 ns | 0.0888 ns |   2.478 ns |  0.89 |    0.03 |      - |     - |     - |         - |
   FromDoubleNullable |        net461 |   2.736 ns | 0.0072 ns | 0.0067 ns |   2.740 ns |  0.95 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable |        net472 |   2.737 ns | 0.0062 ns | 0.0058 ns |   2.736 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
          FromDecimal | .NET Core 2.0 |  53.636 ns | 0.1166 ns | 0.1091 ns |  53.658 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 2.2 |  46.518 ns | 0.0568 ns | 0.0531 ns |  46.516 ns |  0.87 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 3.0 |  47.066 ns | 0.1032 ns | 0.0965 ns |  47.070 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
          FromDecimal |        net461 |  49.374 ns | 0.2614 ns | 0.2445 ns |  49.494 ns |  0.92 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal |        net472 |  49.967 ns | 0.1046 ns | 0.0817 ns |  49.985 ns |  0.93 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  11.446 ns | 0.1099 ns | 0.1028 ns |  11.406 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |   9.071 ns | 0.0257 ns | 0.0241 ns |   9.072 ns |  0.79 |    0.01 |      - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |   9.320 ns | 0.0206 ns | 0.0193 ns |   9.312 ns |  0.81 |    0.01 |      - |     - |     - |         - |
  FromDecimalNullable |        net461 |   9.012 ns | 0.0165 ns | 0.0154 ns |   9.014 ns |  0.79 |    0.01 |      - |     - |     - |         - |
  FromDecimalNullable |        net472 |   9.079 ns | 0.0177 ns | 0.0157 ns |   9.081 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
         FromDateTime | .NET Core 2.0 | 327.004 ns | 0.4453 ns | 0.3718 ns | 327.030 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
         FromDateTime | .NET Core 2.2 | 275.230 ns | 0.6454 ns | 0.5721 ns | 275.321 ns |  0.84 |    0.00 | 0.0262 |     - |     - |     168 B |
         FromDateTime | .NET Core 3.0 | 225.820 ns | 1.7403 ns | 1.6279 ns | 226.356 ns |  0.69 |    0.00 | 0.0100 |     - |     - |      64 B |
         FromDateTime |        net461 | 323.532 ns | 0.4864 ns | 0.4312 ns | 323.604 ns |  0.99 |    0.00 | 0.0300 |     - |     - |     192 B |
         FromDateTime |        net472 | 324.011 ns | 1.2417 ns | 1.0368 ns | 323.703 ns |  0.99 |    0.00 | 0.0300 |     - |     - |     192 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |   2.876 ns | 0.0043 ns | 0.0040 ns |   2.875 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |   2.645 ns | 0.0043 ns | 0.0040 ns |   2.645 ns |  0.92 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |   2.613 ns | 0.0369 ns | 0.0345 ns |   2.591 ns |  0.91 |    0.01 |      - |     - |     - |         - |
 FromDateTimeNullable |        net461 |   3.317 ns | 0.0271 ns | 0.0240 ns |   3.307 ns |  1.15 |    0.01 |      - |     - |     - |         - |
 FromDateTimeNullable |        net472 |   3.333 ns | 0.0336 ns | 0.0315 ns |   3.344 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
           FromObject | .NET Core 2.0 |   3.097 ns | 0.0061 ns | 0.0057 ns |   3.097 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 2.2 |   2.829 ns | 0.0088 ns | 0.0078 ns |   2.827 ns |  0.91 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 3.0 |   2.672 ns | 0.0062 ns | 0.0055 ns |   2.672 ns |  0.86 |    0.00 |      - |     - |     - |         - |
           FromObject |        net461 |   3.216 ns | 0.0049 ns | 0.0043 ns |   3.216 ns |  1.04 |    0.00 |      - |     - |     - |         - |
           FromObject |        net472 |   3.018 ns | 0.0067 ns | 0.0063 ns |   3.019 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
           FromString | .NET Core 2.0 |   1.857 ns | 0.0040 ns | 0.0033 ns |   1.857 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 2.2 |   1.860 ns | 0.0113 ns | 0.0100 ns |   1.858 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 3.0 |   1.756 ns | 0.0113 ns | 0.0106 ns |   1.752 ns |  0.94 |    0.00 |      - |     - |     - |         - |
           FromString |        net461 |   1.816 ns | 0.0035 ns | 0.0031 ns |   1.816 ns |  0.98 |    0.00 |      - |     - |     - |         - |
           FromString |        net472 |   1.819 ns | 0.0076 ns | 0.0067 ns |   1.817 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
             FromEnum | .NET Core 2.0 |  20.923 ns | 0.0522 ns | 0.0488 ns |  20.917 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  21.320 ns | 0.0367 ns | 0.0344 ns |  21.317 ns |  1.02 |    0.00 |      - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  16.949 ns | 0.0242 ns | 0.0227 ns |  16.946 ns |  0.81 |    0.00 |      - |     - |     - |         - |
             FromEnum |        net461 |  23.567 ns | 0.0737 ns | 0.0690 ns |  23.574 ns |  1.13 |    0.00 |      - |     - |     - |         - |
             FromEnum |        net472 |  23.270 ns | 0.0305 ns | 0.0255 ns |  23.267 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
     FromEnumNullable | .NET Core 2.0 |   2.329 ns | 0.0027 ns | 0.0024 ns |   2.330 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |   2.214 ns | 0.0063 ns | 0.0053 ns |   2.216 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |   2.501 ns | 0.0048 ns | 0.0045 ns |   2.503 ns |  1.07 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable |        net461 |   1.990 ns | 0.0043 ns | 0.0040 ns |   1.988 ns |  0.85 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable |        net472 |   2.054 ns | 0.0161 ns | 0.0143 ns |   2.049 ns |  0.88 |    0.01 |      - |     - |     - |         - |
