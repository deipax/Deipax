
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
             FromBool | .NET Core 2.0 |  0.9526 ns | 0.0044 ns | 0.0041 ns |  0.9526 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9299 ns | 0.0040 ns | 0.0031 ns |  0.9295 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.7195 ns | 0.0022 ns | 0.0021 ns |  0.7197 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6458 ns | 0.0022 ns | 0.0021 ns |  0.6460 ns |  0.68 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 |  0.6617 ns | 0.0038 ns | 0.0035 ns |  0.6621 ns |  0.69 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.4299 ns | 0.0036 ns | 0.0032 ns |  1.4295 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.3739 ns | 0.0020 ns | 0.0019 ns |  1.3736 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1821 ns | 0.0045 ns | 0.0035 ns |  1.1822 ns |  0.83 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.8171 ns | 0.0036 ns | 0.0032 ns |  1.8173 ns |  1.27 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.8262 ns | 0.0029 ns | 0.0024 ns |  1.8267 ns |  1.28 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9498 ns | 0.0032 ns | 0.0030 ns |  0.9493 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.7098 ns | 0.0063 ns | 0.0059 ns |  0.7113 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.4914 ns | 0.0054 ns | 0.0048 ns |  0.4896 ns |  0.52 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.4292 ns | 0.0029 ns | 0.0026 ns |  0.4289 ns |  0.45 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.4297 ns | 0.0084 ns | 0.0079 ns |  0.4334 ns |  0.45 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.7318 ns | 0.0014 ns | 0.0013 ns |  0.7316 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.7251 ns | 0.0024 ns | 0.0022 ns |  0.7248 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.6457 ns | 0.0029 ns | 0.0024 ns |  0.6457 ns |  0.88 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.4083 ns | 0.0022 ns | 0.0019 ns |  1.4087 ns |  1.92 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  0.6994 ns | 0.0022 ns | 0.0021 ns |  0.7000 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.7219 ns | 0.0018 ns | 0.0016 ns |  0.7214 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.9425 ns | 0.0037 ns | 0.0035 ns |  0.9430 ns |  1.31 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.7160 ns | 0.0018 ns | 0.0016 ns |  0.7162 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.4266 ns | 0.0020 ns | 0.0019 ns |  0.4263 ns |  0.59 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.4406 ns | 0.0032 ns | 0.0026 ns |  0.4408 ns |  0.61 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.1688 ns | 0.0040 ns | 0.0036 ns |  1.1690 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.1704 ns | 0.0054 ns | 0.0050 ns |  1.1708 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9595 ns | 0.0103 ns | 0.0097 ns |  0.9555 ns |  0.82 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.6389 ns | 0.0035 ns | 0.0029 ns |  1.6393 ns |  1.40 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.6797 ns | 0.0094 ns | 0.0088 ns |  1.6817 ns |  1.44 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.9638 ns | 0.0066 ns | 0.0062 ns |  0.9654 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.9443 ns | 0.0023 ns | 0.0022 ns |  0.9441 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.7176 ns | 0.0035 ns | 0.0031 ns |  0.7176 ns |  0.74 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.6520 ns | 0.0029 ns | 0.0027 ns |  0.6532 ns |  0.68 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.6645 ns | 0.0020 ns | 0.0019 ns |  0.6645 ns |  0.69 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.5029 ns | 0.0043 ns | 0.0040 ns |  1.5033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.1468 ns | 0.0031 ns | 0.0029 ns |  1.1469 ns |  0.76 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9586 ns | 0.0085 ns | 0.0080 ns |  0.9613 ns |  0.64 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  2.2440 ns | 0.0042 ns | 0.0039 ns |  2.2440 ns |  1.49 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.6545 ns | 0.0120 ns | 0.0112 ns |  1.6580 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.7223 ns | 0.0031 ns | 0.0029 ns |  0.7225 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.9218 ns | 0.0020 ns | 0.0017 ns |  0.9221 ns |  1.28 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.7150 ns | 0.0032 ns | 0.0027 ns |  0.7152 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.1466 ns | 0.0049 ns | 0.0043 ns |  1.1454 ns |  1.59 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  0.4360 ns | 0.0020 ns | 0.0017 ns |  0.4355 ns |  0.60 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.2375 ns | 0.0070 ns | 0.0066 ns |  1.2380 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.1747 ns | 0.0116 ns | 0.0108 ns |  1.1789 ns |  0.95 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  0.9560 ns | 0.0031 ns | 0.0029 ns |  0.9561 ns |  0.77 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.6428 ns | 0.0043 ns | 0.0040 ns |  1.6416 ns |  1.33 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.6583 ns | 0.0042 ns | 0.0040 ns |  1.6562 ns |  1.34 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.9501 ns | 0.0017 ns | 0.0015 ns |  0.9505 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.9263 ns | 0.0058 ns | 0.0054 ns |  0.9270 ns |  0.98 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.7236 ns | 0.0089 ns | 0.0084 ns |  0.7206 ns |  0.76 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.6534 ns | 0.0029 ns | 0.0025 ns |  0.6533 ns |  0.69 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.6609 ns | 0.0020 ns | 0.0019 ns |  0.6605 ns |  0.70 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  0.9492 ns | 0.0024 ns | 0.0019 ns |  0.9496 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.1650 ns | 0.0027 ns | 0.0024 ns |  1.1657 ns |  1.23 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  0.9543 ns | 0.0019 ns | 0.0018 ns |  0.9546 ns |  1.01 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.6439 ns | 0.0042 ns | 0.0039 ns |  1.6431 ns |  1.73 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.6586 ns | 0.0032 ns | 0.0030 ns |  1.6583 ns |  1.75 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.7188 ns | 0.0031 ns | 0.0029 ns |  0.7188 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.9440 ns | 0.0040 ns | 0.0037 ns |  0.9442 ns |  1.31 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.7211 ns | 0.0031 ns | 0.0029 ns |  0.7209 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  0.4358 ns | 0.0020 ns | 0.0016 ns |  0.4362 ns |  0.61 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  0.4495 ns | 0.0020 ns | 0.0019 ns |  0.4501 ns |  0.63 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  0.9569 ns | 0.0051 ns | 0.0048 ns |  0.9574 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  0.9398 ns | 0.0024 ns | 0.0023 ns |  0.9397 ns |  0.98 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  0.8662 ns | 0.0117 ns | 0.0109 ns |  0.8608 ns |  0.91 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.6582 ns | 0.0228 ns | 0.0213 ns |  1.6709 ns |  1.73 |    0.03 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.6474 ns | 0.0014 ns | 0.0012 ns |  1.6474 ns |  1.72 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.9474 ns | 0.0020 ns | 0.0018 ns |  0.9480 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.7274 ns | 0.0017 ns | 0.0015 ns |  0.7270 ns |  0.77 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.9247 ns | 0.0026 ns | 0.0023 ns |  0.9253 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.7201 ns | 0.0024 ns | 0.0022 ns |  0.7201 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.7311 ns | 0.0023 ns | 0.0019 ns |  0.7313 ns |  0.77 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.0975 ns | 0.0079 ns | 0.0074 ns |  1.0963 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.1787 ns | 0.0033 ns | 0.0027 ns |  1.1778 ns |  1.07 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.1797 ns | 0.0028 ns | 0.0026 ns |  1.1802 ns |  1.07 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.6516 ns | 0.0031 ns | 0.0029 ns |  1.6514 ns |  1.50 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.6670 ns | 0.0056 ns | 0.0052 ns |  1.6666 ns |  1.52 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  0.7228 ns | 0.0032 ns | 0.0030 ns |  0.7218 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  0.9055 ns | 0.0027 ns | 0.0024 ns |  0.9052 ns |  1.25 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.7249 ns | 0.0020 ns | 0.0019 ns |  0.7243 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  0.7028 ns | 0.0111 ns | 0.0103 ns |  0.7076 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  0.7071 ns | 0.0029 ns | 0.0027 ns |  0.7068 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.4546 ns | 0.0031 ns | 0.0029 ns |  1.4557 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.7474 ns | 0.0022 ns | 0.0019 ns |  1.7475 ns |  1.20 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.7335 ns | 0.0171 ns | 0.0160 ns |  1.7260 ns |  1.19 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.6991 ns | 0.0029 ns | 0.0027 ns |  2.6997 ns |  1.86 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.1078 ns | 0.0025 ns | 0.0022 ns |  2.1077 ns |  1.45 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.1925 ns | 0.0072 ns | 0.0067 ns |  1.1932 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  0.9576 ns | 0.0039 ns | 0.0037 ns |  0.9577 ns |  0.80 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.9402 ns | 0.0037 ns | 0.0033 ns |  0.9393 ns |  0.79 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  0.9344 ns | 0.0038 ns | 0.0033 ns |  0.9348 ns |  0.78 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  0.9324 ns | 0.0030 ns | 0.0026 ns |  0.9319 ns |  0.78 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.9367 ns | 0.0036 ns | 0.0032 ns |  1.9366 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.8720 ns | 0.0033 ns | 0.0029 ns |  1.8722 ns |  0.97 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.6995 ns | 0.0035 ns | 0.0032 ns |  1.6992 ns |  0.88 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.2337 ns | 0.0030 ns | 0.0028 ns |  2.2345 ns |  1.15 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.2413 ns | 0.0037 ns | 0.0035 ns |  2.2414 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  0.6933 ns | 0.0027 ns | 0.0025 ns |  0.6942 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  0.9468 ns | 0.0085 ns | 0.0079 ns |  0.9496 ns |  1.37 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  0.7317 ns | 0.0114 ns | 0.0106 ns |  0.7388 ns |  1.06 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  0.9498 ns | 0.0036 ns | 0.0034 ns |  0.9495 ns |  1.37 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 |  0.9560 ns | 0.0023 ns | 0.0021 ns |  0.9560 ns |  1.38 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.5069 ns | 0.0124 ns | 0.0116 ns |  1.5014 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  0.9313 ns | 0.0038 ns | 0.0033 ns |  0.9312 ns |  0.62 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  0.9319 ns | 0.0028 ns | 0.0026 ns |  0.9314 ns |  0.62 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.8646 ns | 0.0037 ns | 0.0029 ns |  1.8642 ns |  1.24 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.8766 ns | 0.0032 ns | 0.0027 ns |  1.8761 ns |  1.25 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  0.6920 ns | 0.0028 ns | 0.0027 ns |  0.6919 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  0.7106 ns | 0.0028 ns | 0.0025 ns |  0.7108 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  0.7126 ns | 0.0025 ns | 0.0023 ns |  0.7128 ns |  1.03 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |  0.7221 ns | 0.0035 ns | 0.0033 ns |  0.7233 ns |  1.04 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  0.7436 ns | 0.0065 ns | 0.0058 ns |  0.7451 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.5740 ns | 0.0024 ns | 0.0023 ns |  1.5742 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.5067 ns | 0.0031 ns | 0.0028 ns |  1.5071 ns |  0.96 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.7625 ns | 0.0106 ns | 0.0099 ns |  1.7639 ns |  1.12 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  1.9949 ns | 0.0036 ns | 0.0034 ns |  1.9962 ns |  1.27 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  1.9985 ns | 0.0044 ns | 0.0041 ns |  1.9986 ns |  1.27 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |  7.9787 ns | 0.0177 ns | 0.0166 ns |  7.9789 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |  8.0803 ns | 0.0517 ns | 0.0483 ns |  8.0559 ns |  1.01 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.4634 ns | 0.0068 ns | 0.0057 ns |  5.4640 ns |  0.68 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 |  9.2632 ns | 0.0750 ns | 0.0702 ns |  9.3017 ns |  1.16 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net472 |  7.9681 ns | 0.0080 ns | 0.0075 ns |  7.9692 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 23.2117 ns | 0.0250 ns | 0.0234 ns | 23.2173 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 23.1389 ns | 0.0276 ns | 0.0216 ns | 23.1363 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 17.3302 ns | 0.0351 ns | 0.0329 ns | 17.3376 ns |  0.75 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 23.0126 ns | 0.0305 ns | 0.0270 ns | 23.0159 ns |  0.99 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 23.2912 ns | 0.0323 ns | 0.0286 ns | 23.2982 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9631 ns | 0.0069 ns | 0.0065 ns |  0.9653 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7328 ns | 0.0033 ns | 0.0031 ns |  0.7331 ns |  0.76 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.5393 ns | 0.0092 ns | 0.0086 ns |  0.5345 ns |  0.56 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7034 ns | 0.0026 ns | 0.0023 ns |  0.7032 ns |  0.73 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7101 ns | 0.0034 ns | 0.0032 ns |  0.7086 ns |  0.74 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.3791 ns | 0.0036 ns | 0.0034 ns |  1.3792 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.4114 ns | 0.0039 ns | 0.0036 ns |  1.4118 ns |  1.02 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.3965 ns | 0.0027 ns | 0.0025 ns |  1.3971 ns |  1.01 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.4078 ns | 0.0038 ns | 0.0036 ns |  1.4081 ns |  1.02 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.4176 ns | 0.0022 ns | 0.0019 ns |  1.4169 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.3637 ns | 0.0048 ns | 0.0045 ns |  2.3648 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.2092 ns | 0.0038 ns | 0.0035 ns |  2.2099 ns |  0.93 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.1890 ns | 0.0232 ns | 0.0217 ns |  2.1848 ns |  0.93 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  2.2095 ns | 0.0034 ns | 0.0032 ns |  2.2102 ns |  0.93 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  2.7364 ns | 0.0101 ns | 0.0084 ns |  2.7381 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 58.3608 ns | 0.0752 ns | 0.0704 ns | 58.3697 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 61.8437 ns | 0.0846 ns | 0.0750 ns | 61.8694 ns |  1.06 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 45.1942 ns | 0.0811 ns | 0.0758 ns | 45.1801 ns |  0.77 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 58.0741 ns | 0.3647 ns | 0.3412 ns | 58.2214 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 | 57.7130 ns | 0.0638 ns | 0.0566 ns | 57.7098 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.9498 ns | 0.0017 ns | 0.0015 ns |  0.9496 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.7133 ns | 0.0022 ns | 0.0019 ns |  0.7127 ns |  0.75 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.7304 ns | 0.0045 ns | 0.0040 ns |  0.7309 ns |  0.77 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.7215 ns | 0.0026 ns | 0.0024 ns |  0.7220 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.7298 ns | 0.0031 ns | 0.0029 ns |  0.7305 ns |  0.77 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  0.9746 ns | 0.0017 ns | 0.0015 ns |  0.9747 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.1644 ns | 0.0028 ns | 0.0024 ns |  1.1638 ns |  1.19 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.1789 ns | 0.0149 ns | 0.0139 ns |  1.1855 ns |  1.21 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.6751 ns | 0.0046 ns | 0.0043 ns |  1.6749 ns |  1.72 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.6859 ns | 0.0036 ns | 0.0034 ns |  1.6865 ns |  1.73 |    0.00 |     - |     - |     - |         - |
