
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
             FromBool | .NET Core 2.0 |   3.301 ns | 0.0255 ns | 0.0239 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromBool | .NET Core 2.2 |   3.748 ns | 0.0103 ns | 0.0097 ns |  1.14 |    0.01 |      - |     - |     - |         - |
             FromBool | .NET Core 3.0 |   3.515 ns | 0.0104 ns | 0.0092 ns |  1.07 |    0.01 |      - |     - |     - |         - |
             FromBool |        net461 |   3.589 ns | 0.0069 ns | 0.0064 ns |  1.09 |    0.01 |      - |     - |     - |         - |
             FromBool |        net472 |   3.907 ns | 0.0214 ns | 0.0200 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
     FromBoolNullable | .NET Core 2.0 |   1.888 ns | 0.0066 ns | 0.0059 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |   2.171 ns | 0.0140 ns | 0.0131 ns |  1.15 |    0.01 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |   1.983 ns | 0.0063 ns | 0.0059 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     FromBoolNullable |        net461 |   1.984 ns | 0.0072 ns | 0.0060 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable |        net472 |   2.310 ns | 0.0053 ns | 0.0045 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
             FromChar | .NET Core 2.0 |   4.764 ns | 0.0252 ns | 0.0224 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromChar | .NET Core 2.2 |   4.841 ns | 0.0270 ns | 0.0240 ns |  1.02 |    0.01 | 0.0051 |     - |     - |      32 B |
             FromChar | .NET Core 3.0 |   4.449 ns | 0.0157 ns | 0.0131 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromChar |        net461 |   7.015 ns | 0.0268 ns | 0.0224 ns |  1.47 |    0.01 | 0.0051 |     - |     - |      32 B |
             FromChar |        net472 |   7.149 ns | 0.0268 ns | 0.0223 ns |  1.50 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
     FromCharNullable | .NET Core 2.0 |   5.789 ns | 0.0282 ns | 0.0250 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
     FromCharNullable | .NET Core 2.2 |   5.433 ns | 0.0116 ns | 0.0097 ns |  0.94 |    0.00 | 0.0051 |     - |     - |      32 B |
     FromCharNullable | .NET Core 3.0 |   5.036 ns | 0.0276 ns | 0.0245 ns |  0.87 |    0.01 | 0.0038 |     - |     - |      24 B |
     FromCharNullable |        net461 |   7.707 ns | 0.0381 ns | 0.0338 ns |  1.33 |    0.01 | 0.0051 |     - |     - |      32 B |
     FromCharNullable |        net472 |   7.737 ns | 0.0583 ns | 0.0545 ns |  1.34 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
            FromSByte | .NET Core 2.0 |  32.730 ns | 0.0731 ns | 0.0684 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromSByte | .NET Core 2.2 |  18.531 ns | 0.0702 ns | 0.0622 ns |  0.57 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromSByte | .NET Core 3.0 |  13.998 ns | 0.2995 ns | 0.2802 ns |  0.43 |    0.01 |      - |     - |     - |         - |
            FromSByte |        net461 |  33.090 ns | 0.1159 ns | 0.1084 ns |  1.01 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromSByte |        net472 |  33.150 ns | 0.0742 ns | 0.0658 ns |  1.01 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  30.264 ns | 0.0952 ns | 0.0844 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
    FromSByteNullable | .NET Core 2.2 |  20.161 ns | 0.0840 ns | 0.0786 ns |  0.67 |    0.00 | 0.0051 |     - |     - |      32 B |
    FromSByteNullable | .NET Core 3.0 |  14.204 ns | 0.0478 ns | 0.0424 ns |  0.47 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable |        net461 |  34.300 ns | 0.0607 ns | 0.0538 ns |  1.13 |    0.00 | 0.0051 |     - |     - |      32 B |
    FromSByteNullable |        net472 |  34.277 ns | 0.1243 ns | 0.1163 ns |  1.13 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
             FromByte | .NET Core 2.0 |  30.176 ns | 0.0915 ns | 0.0856 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromByte | .NET Core 2.2 |  18.177 ns | 0.1368 ns | 0.1280 ns |  0.60 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromByte | .NET Core 3.0 |  13.412 ns | 0.2042 ns | 0.1910 ns |  0.44 |    0.01 |      - |     - |     - |         - |
             FromByte |        net461 |  33.275 ns | 0.1059 ns | 0.0884 ns |  1.10 |    0.01 | 0.0051 |     - |     - |      32 B |
             FromByte |        net472 |  33.442 ns | 0.0728 ns | 0.0681 ns |  1.11 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
     FromByteNullable | .NET Core 2.0 |  30.793 ns | 0.2078 ns | 0.1842 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
     FromByteNullable | .NET Core 2.2 |  19.661 ns | 0.0625 ns | 0.0584 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
     FromByteNullable | .NET Core 3.0 |  14.335 ns | 0.2385 ns | 0.2231 ns |  0.46 |    0.01 |      - |     - |     - |         - |
     FromByteNullable |        net461 |  34.530 ns | 0.2337 ns | 0.2186 ns |  1.12 |    0.01 | 0.0051 |     - |     - |      32 B |
     FromByteNullable |        net472 |  34.299 ns | 0.2926 ns | 0.2737 ns |  1.11 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
            FromShort | .NET Core 2.0 |  29.822 ns | 0.0553 ns | 0.0517 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromShort | .NET Core 2.2 |  18.347 ns | 0.0597 ns | 0.0529 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromShort | .NET Core 3.0 |  13.958 ns | 0.1465 ns | 0.1370 ns |  0.47 |    0.00 |      - |     - |     - |         - |
            FromShort |        net461 |  32.973 ns | 0.0424 ns | 0.0354 ns |  1.11 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromShort |        net472 |  34.184 ns | 0.1141 ns | 0.1068 ns |  1.15 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
    FromShortNullable | .NET Core 2.0 |  30.418 ns | 0.1155 ns | 0.1024 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
    FromShortNullable | .NET Core 2.2 |  19.286 ns | 0.0723 ns | 0.0677 ns |  0.63 |    0.00 | 0.0051 |     - |     - |      32 B |
    FromShortNullable | .NET Core 3.0 |  14.334 ns | 0.0405 ns | 0.0338 ns |  0.47 |    0.00 |      - |     - |     - |         - |
    FromShortNullable |        net461 |  33.747 ns | 0.1024 ns | 0.0958 ns |  1.11 |    0.01 | 0.0051 |     - |     - |      32 B |
    FromShortNullable |        net472 |  34.066 ns | 0.0920 ns | 0.0861 ns |  1.12 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
           FromUShort | .NET Core 2.0 |  27.303 ns | 0.0420 ns | 0.0350 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
           FromUShort | .NET Core 2.2 |  18.160 ns | 0.0370 ns | 0.0328 ns |  0.67 |    0.00 | 0.0051 |     - |     - |      32 B |
           FromUShort | .NET Core 3.0 |  13.597 ns | 0.0645 ns | 0.0604 ns |  0.50 |    0.00 |      - |     - |     - |         - |
           FromUShort |        net461 |  31.831 ns | 0.0490 ns | 0.0434 ns |  1.17 |    0.00 | 0.0051 |     - |     - |      32 B |
           FromUShort |        net472 |  32.105 ns | 0.1184 ns | 0.0989 ns |  1.18 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  27.744 ns | 0.0642 ns | 0.0569 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
   FromUShortNullable | .NET Core 2.2 |  18.725 ns | 0.0548 ns | 0.0513 ns |  0.67 |    0.00 | 0.0051 |     - |     - |      32 B |
   FromUShortNullable | .NET Core 3.0 |  14.026 ns | 0.1381 ns | 0.1291 ns |  0.51 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable |        net461 |  33.328 ns | 0.0681 ns | 0.0568 ns |  1.20 |    0.00 | 0.0051 |     - |     - |      32 B |
   FromUShortNullable |        net472 |  33.247 ns | 0.0862 ns | 0.0720 ns |  1.20 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
              FromInt | .NET Core 2.0 |  29.913 ns | 0.0688 ns | 0.0644 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
              FromInt | .NET Core 2.2 |  18.309 ns | 0.0427 ns | 0.0378 ns |  0.61 |    0.00 | 0.0051 |     - |     - |      32 B |
              FromInt | .NET Core 3.0 |  13.435 ns | 0.0206 ns | 0.0172 ns |  0.45 |    0.00 |      - |     - |     - |         - |
              FromInt |        net461 |  32.754 ns | 0.0858 ns | 0.0760 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
              FromInt |        net472 |  32.333 ns | 0.1179 ns | 0.1046 ns |  1.08 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
      FromIntNullable | .NET Core 2.0 |  31.199 ns | 0.0945 ns | 0.0838 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
      FromIntNullable | .NET Core 2.2 |  18.911 ns | 0.0312 ns | 0.0277 ns |  0.61 |    0.00 | 0.0051 |     - |     - |      32 B |
      FromIntNullable | .NET Core 3.0 |  13.912 ns | 0.0338 ns | 0.0282 ns |  0.45 |    0.00 |      - |     - |     - |         - |
      FromIntNullable |        net461 |  33.911 ns | 0.0542 ns | 0.0507 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
      FromIntNullable |        net472 |  34.043 ns | 0.1239 ns | 0.1159 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
             FromUInt | .NET Core 2.0 |  27.201 ns | 0.0673 ns | 0.0596 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromUInt | .NET Core 2.2 |  18.165 ns | 0.1007 ns | 0.0942 ns |  0.67 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromUInt | .NET Core 3.0 |  13.153 ns | 0.0516 ns | 0.0483 ns |  0.48 |    0.00 |      - |     - |     - |         - |
             FromUInt |        net461 |  31.903 ns | 0.1165 ns | 0.1032 ns |  1.17 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromUInt |        net472 |  32.595 ns | 0.0908 ns | 0.0758 ns |  1.20 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  27.872 ns | 0.2055 ns | 0.1922 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
     FromUIntNullable | .NET Core 2.2 |  18.474 ns | 0.1192 ns | 0.1115 ns |  0.66 |    0.00 | 0.0051 |     - |     - |      32 B |
     FromUIntNullable | .NET Core 3.0 |  13.589 ns | 0.0259 ns | 0.0242 ns |  0.49 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable |        net461 |  34.886 ns | 0.2049 ns | 0.1817 ns |  1.25 |    0.01 | 0.0051 |     - |     - |      32 B |
     FromUIntNullable |        net472 |  33.227 ns | 0.2412 ns | 0.2257 ns |  1.19 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
             FromLong | .NET Core 2.0 |  33.499 ns | 0.0980 ns | 0.0869 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromLong | .NET Core 2.2 |  19.703 ns | 0.0790 ns | 0.0739 ns |  0.59 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromLong | .NET Core 3.0 |  13.539 ns | 0.0981 ns | 0.0918 ns |  0.40 |    0.00 |      - |     - |     - |         - |
             FromLong |        net461 |  34.479 ns | 0.0911 ns | 0.0807 ns |  1.03 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromLong |        net472 |  34.284 ns | 0.0548 ns | 0.0485 ns |  1.02 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
     FromLongNullable | .NET Core 2.0 |  34.664 ns | 0.2375 ns | 0.2222 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
     FromLongNullable | .NET Core 2.2 |  20.985 ns | 0.1056 ns | 0.0988 ns |  0.61 |    0.00 | 0.0051 |     - |     - |      32 B |
     FromLongNullable | .NET Core 3.0 |  14.635 ns | 0.3066 ns | 0.3650 ns |  0.42 |    0.01 |      - |     - |     - |         - |
     FromLongNullable |        net461 |  35.396 ns | 0.0895 ns | 0.0837 ns |  1.02 |    0.01 | 0.0051 |     - |     - |      32 B |
     FromLongNullable |        net472 |  35.552 ns | 0.0877 ns | 0.0778 ns |  1.03 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
            FromULong | .NET Core 2.0 |  31.183 ns | 0.1259 ns | 0.1178 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromULong | .NET Core 2.2 |  19.508 ns | 0.0509 ns | 0.0476 ns |  0.63 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromULong | .NET Core 3.0 |  12.993 ns | 0.2717 ns | 0.2907 ns |  0.42 |    0.01 |      - |     - |     - |         - |
            FromULong |        net461 |  33.261 ns | 0.0780 ns | 0.0729 ns |  1.07 |    0.01 | 0.0051 |     - |     - |      32 B |
            FromULong |        net472 |  33.530 ns | 0.1296 ns | 0.1213 ns |  1.08 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
    FromULongNullable | .NET Core 2.0 |  34.495 ns | 0.0880 ns | 0.0780 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
    FromULongNullable | .NET Core 2.2 |  20.702 ns | 0.0517 ns | 0.0404 ns |  0.60 |    0.00 | 0.0051 |     - |     - |      32 B |
    FromULongNullable | .NET Core 3.0 |  14.338 ns | 0.0482 ns | 0.0403 ns |  0.42 |    0.00 |      - |     - |     - |         - |
    FromULongNullable |        net461 |  34.853 ns | 0.0859 ns | 0.0717 ns |  1.01 |    0.00 | 0.0051 |     - |     - |      32 B |
    FromULongNullable |        net472 |  34.362 ns | 0.0708 ns | 0.0662 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
            FromFloat | .NET Core 2.0 | 168.051 ns | 0.9111 ns | 0.7608 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
            FromFloat | .NET Core 2.2 | 106.136 ns | 0.1411 ns | 0.1251 ns |  0.63 |    0.00 | 0.0050 |     - |     - |      32 B |
            FromFloat | .NET Core 3.0 | 113.164 ns | 0.1525 ns | 0.1273 ns |  0.67 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromFloat |        net461 | 282.589 ns | 0.3900 ns | 0.3648 ns |  1.68 |    0.01 | 0.0048 |     - |     - |      32 B |
            FromFloat |        net472 | 282.722 ns | 0.7216 ns | 0.6397 ns |  1.68 |    0.01 | 0.0048 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
    FromFloatNullable | .NET Core 2.0 | 167.289 ns | 0.9308 ns | 0.8707 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
    FromFloatNullable | .NET Core 2.2 | 107.246 ns | 0.3126 ns | 0.2924 ns |  0.64 |    0.00 | 0.0050 |     - |     - |      32 B |
    FromFloatNullable | .NET Core 3.0 | 112.709 ns | 0.2260 ns | 0.2114 ns |  0.67 |    0.00 | 0.0038 |     - |     - |      24 B |
    FromFloatNullable |        net461 | 283.874 ns | 0.5381 ns | 0.4770 ns |  1.70 |    0.01 | 0.0048 |     - |     - |      32 B |
    FromFloatNullable |        net472 | 283.170 ns | 0.6311 ns | 0.5270 ns |  1.69 |    0.01 | 0.0048 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
           FromDouble | .NET Core 2.0 | 192.991 ns | 0.3805 ns | 0.3560 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
           FromDouble | .NET Core 2.2 | 109.787 ns | 0.2059 ns | 0.1926 ns |  0.57 |    0.00 | 0.0050 |     - |     - |      32 B |
           FromDouble | .NET Core 3.0 | 110.396 ns | 0.3334 ns | 0.2955 ns |  0.57 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromDouble |        net461 | 298.972 ns | 0.5443 ns | 0.4825 ns |  1.55 |    0.00 | 0.0048 |     - |     - |      32 B |
           FromDouble |        net472 | 300.452 ns | 1.5913 ns | 1.4885 ns |  1.56 |    0.01 | 0.0048 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 198.877 ns | 1.4904 ns | 1.3941 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
   FromDoubleNullable | .NET Core 2.2 | 112.730 ns | 0.2493 ns | 0.2210 ns |  0.57 |    0.00 | 0.0050 |     - |     - |      32 B |
   FromDoubleNullable | .NET Core 3.0 | 112.492 ns | 0.5252 ns | 0.4913 ns |  0.57 |    0.00 | 0.0038 |     - |     - |      24 B |
   FromDoubleNullable |        net461 | 301.086 ns | 0.6578 ns | 0.5493 ns |  1.51 |    0.01 | 0.0048 |     - |     - |      32 B |
   FromDoubleNullable |        net472 | 301.279 ns | 0.5113 ns | 0.4270 ns |  1.52 |    0.01 | 0.0048 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
          FromDecimal | .NET Core 2.0 |  55.745 ns | 0.3021 ns | 0.2826 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 2.2 |  49.629 ns | 0.0791 ns | 0.0702 ns |  0.89 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 3.0 |  49.587 ns | 0.0915 ns | 0.0715 ns |  0.89 |    0.01 | 0.0038 |     - |     - |      24 B |
          FromDecimal |        net461 |  52.785 ns | 0.0779 ns | 0.0729 ns |  0.95 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal |        net472 |  53.670 ns | 0.0893 ns | 0.0745 ns |  0.96 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  57.313 ns | 0.0687 ns | 0.0573 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
  FromDecimalNullable | .NET Core 2.2 |  52.056 ns | 0.0870 ns | 0.0771 ns |  0.91 |    0.00 | 0.0051 |     - |     - |      32 B |
  FromDecimalNullable | .NET Core 3.0 |  51.857 ns | 0.1959 ns | 0.1736 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
  FromDecimalNullable |        net461 |  58.002 ns | 0.0884 ns | 0.0784 ns |  1.01 |    0.00 | 0.0051 |     - |     - |      32 B |
  FromDecimalNullable |        net472 |  57.713 ns | 0.0656 ns | 0.0613 ns |  1.01 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |       |         |        |       |       |           |
         FromDateTime | .NET Core 2.0 | 312.690 ns | 0.8305 ns | 0.7362 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
         FromDateTime | .NET Core 2.2 | 277.813 ns | 0.7489 ns | 0.7005 ns |  0.89 |    0.00 | 0.0262 |     - |     - |     168 B |
         FromDateTime | .NET Core 3.0 | 226.400 ns | 0.6751 ns | 0.5985 ns |  0.72 |    0.00 | 0.0100 |     - |     - |      64 B |
         FromDateTime |        net461 | 332.084 ns | 0.8878 ns | 0.8304 ns |  1.06 |    0.00 | 0.0300 |     - |     - |     192 B |
         FromDateTime |        net472 | 329.705 ns | 1.2876 ns | 1.0752 ns |  1.05 |    0.00 | 0.0300 |     - |     - |     192 B |
                      |               |            |           |           |       |         |        |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |   3.019 ns | 0.0106 ns | 0.0089 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |   3.543 ns | 0.0112 ns | 0.0099 ns |  1.17 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |   2.675 ns | 0.0143 ns | 0.0134 ns |  0.89 |    0.01 |      - |     - |     - |         - |
 FromDateTimeNullable |        net461 |   3.060 ns | 0.0089 ns | 0.0074 ns |  1.01 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable |        net472 |   3.045 ns | 0.0357 ns | 0.0316 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
           FromObject | .NET Core 2.0 |   2.382 ns | 0.0175 ns | 0.0155 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 2.2 |   2.207 ns | 0.0176 ns | 0.0156 ns |  0.93 |    0.01 |      - |     - |     - |         - |
           FromObject | .NET Core 3.0 |   2.134 ns | 0.0108 ns | 0.0090 ns |  0.90 |    0.01 |      - |     - |     - |         - |
           FromObject |        net461 |   3.275 ns | 0.0225 ns | 0.0211 ns |  1.38 |    0.01 |      - |     - |     - |         - |
           FromObject |        net472 |   3.232 ns | 0.0076 ns | 0.0071 ns |  1.36 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
           FromString | .NET Core 2.0 |   1.638 ns | 0.0056 ns | 0.0050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 2.2 |   1.870 ns | 0.0132 ns | 0.0124 ns |  1.14 |    0.01 |      - |     - |     - |         - |
           FromString | .NET Core 3.0 |   1.768 ns | 0.0144 ns | 0.0128 ns |  1.08 |    0.01 |      - |     - |     - |         - |
           FromString |        net461 |   2.147 ns | 0.0175 ns | 0.0164 ns |  1.31 |    0.01 |      - |     - |     - |         - |
           FromString |        net472 |   2.080 ns | 0.0194 ns | 0.0182 ns |  1.27 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |       |         |        |       |       |           |
             FromEnum | .NET Core 2.0 |  52.707 ns | 0.0851 ns | 0.0796 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromEnum | .NET Core 2.2 |  51.120 ns | 0.2535 ns | 0.2372 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromEnum | .NET Core 3.0 |  29.567 ns | 0.1099 ns | 0.0918 ns |  0.56 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromEnum |        net461 | 292.169 ns | 0.7480 ns | 0.6631 ns |  5.54 |    0.02 | 0.0114 |     - |     - |      72 B |
             FromEnum |        net472 | 293.589 ns | 1.0970 ns | 1.0262 ns |  5.57 |    0.02 | 0.0114 |     - |     - |      72 B |
                      |               |            |           |           |       |         |        |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  52.669 ns | 0.1121 ns | 0.0936 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
     FromEnumNullable | .NET Core 2.2 |  52.960 ns | 0.3123 ns | 0.2921 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
     FromEnumNullable | .NET Core 3.0 |  31.204 ns | 0.1380 ns | 0.1224 ns |  0.59 |    0.00 | 0.0038 |     - |     - |      24 B |
     FromEnumNullable |        net461 | 294.613 ns | 2.0559 ns | 1.9231 ns |  5.59 |    0.04 | 0.0114 |     - |     - |      72 B |
     FromEnumNullable |        net472 | 289.456 ns | 1.1414 ns | 1.0118 ns |  5.50 |    0.02 | 0.0114 |     - |     - |      72 B |
