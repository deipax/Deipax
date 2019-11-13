
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
             FromBool | .NET Core 2.0 |  0.6423 ns | 0.0026 ns | 0.0024 ns |  0.6427 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  1.1597 ns | 0.0015 ns | 0.0014 ns |  1.1598 ns |  1.81 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  1.0898 ns | 0.0023 ns | 0.0019 ns |  1.0898 ns |  1.70 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9132 ns | 0.0040 ns | 0.0038 ns |  0.9142 ns |  1.42 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  1.1700 ns | 0.0072 ns | 0.0067 ns |  1.1721 ns |  1.82 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1374 ns | 0.0041 ns | 0.0038 ns |  1.1372 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.4144 ns | 0.0134 ns | 0.0125 ns |  1.4085 ns |  1.24 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1724 ns | 0.0046 ns | 0.0043 ns |  1.1740 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.6356 ns | 0.0024 ns | 0.0023 ns |  1.6357 ns |  1.44 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.8737 ns | 0.0029 ns | 0.0025 ns |  1.8743 ns |  1.65 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.5336 ns | 0.0018 ns | 0.0014 ns |  0.5334 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.7394 ns | 0.0023 ns | 0.0018 ns |  0.7395 ns |  1.39 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.6432 ns | 0.0021 ns | 0.0020 ns |  0.6431 ns |  1.21 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.4299 ns | 0.0017 ns | 0.0015 ns |  0.4297 ns |  0.81 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.7011 ns | 0.0021 ns | 0.0019 ns |  0.7013 ns |  1.32 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.8988 ns | 0.0023 ns | 0.0021 ns |  0.8982 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.1762 ns | 0.0042 ns | 0.0037 ns |  1.1769 ns |  1.31 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1182 ns | 0.0018 ns | 0.0017 ns |  1.1178 ns |  1.24 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.5959 ns | 0.0033 ns | 0.0031 ns |  1.5963 ns |  1.78 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.6282 ns | 0.0032 ns | 0.0030 ns |  1.6287 ns |  1.81 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.0717 ns | 0.0020 ns | 0.0019 ns |  1.0720 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.1962 ns | 0.0076 ns | 0.0071 ns |  1.1974 ns |  1.12 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.8763 ns | 0.0022 ns | 0.0019 ns |  0.8765 ns |  0.82 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.4953 ns | 0.0027 ns | 0.0024 ns |  1.4950 ns |  1.40 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.6351 ns | 0.0030 ns | 0.0028 ns |  1.6360 ns |  1.53 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.4306 ns | 0.0050 ns | 0.0042 ns |  1.4309 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.4840 ns | 0.0028 ns | 0.0027 ns |  1.4846 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9117 ns | 0.0028 ns | 0.0027 ns |  0.9118 ns |  0.64 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.0258 ns | 0.0026 ns | 0.0024 ns |  2.0265 ns |  1.42 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.1041 ns | 0.0035 ns | 0.0033 ns |  2.1033 ns |  1.47 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.4120 ns | 0.0015 ns | 0.0013 ns |  0.4120 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7112 ns | 0.0024 ns | 0.0021 ns |  0.7117 ns |  1.73 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.6237 ns | 0.0012 ns | 0.0010 ns |  0.6235 ns |  1.51 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.4306 ns | 0.0016 ns | 0.0015 ns |  0.4299 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.7142 ns | 0.0025 ns | 0.0024 ns |  0.7146 ns |  1.73 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.8759 ns | 0.0028 ns | 0.0026 ns |  0.8762 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.1907 ns | 0.0036 ns | 0.0033 ns |  1.1913 ns |  1.36 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9434 ns | 0.0029 ns | 0.0026 ns |  0.9441 ns |  1.08 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.5755 ns | 0.0037 ns | 0.0035 ns |  1.5753 ns |  1.80 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.6120 ns | 0.0162 ns | 0.0151 ns |  1.6055 ns |  1.84 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.0684 ns | 0.0043 ns | 0.0038 ns |  1.0686 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.1207 ns | 0.0028 ns | 0.0024 ns |  1.1206 ns |  1.05 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.8543 ns | 0.0028 ns | 0.0023 ns |  0.8547 ns |  0.80 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.5001 ns | 0.0027 ns | 0.0025 ns |  1.4999 ns |  1.40 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  1.6176 ns | 0.0022 ns | 0.0020 ns |  1.6177 ns |  1.51 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.5728 ns | 0.0030 ns | 0.0027 ns |  1.5721 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.5815 ns | 0.0044 ns | 0.0041 ns |  1.5811 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  0.9480 ns | 0.0064 ns | 0.0060 ns |  0.9498 ns |  0.60 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.2057 ns | 0.0023 ns | 0.0019 ns |  2.2060 ns |  1.40 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.5051 ns | 0.0028 ns | 0.0026 ns |  2.5044 ns |  1.59 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.4330 ns | 0.0011 ns | 0.0010 ns |  0.4328 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  1.1171 ns | 0.0028 ns | 0.0026 ns |  1.1169 ns |  2.58 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6450 ns | 0.0023 ns | 0.0022 ns |  0.6456 ns |  1.49 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.4449 ns | 0.0010 ns | 0.0009 ns |  0.4452 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.6895 ns | 0.0029 ns | 0.0027 ns |  0.6901 ns |  1.59 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  0.8984 ns | 0.0056 ns | 0.0053 ns |  0.8975 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.1725 ns | 0.0015 ns | 0.0014 ns |  1.1727 ns |  1.31 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  0.9243 ns | 0.0037 ns | 0.0034 ns |  0.9242 ns |  1.03 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.5942 ns | 0.0036 ns | 0.0034 ns |  1.5931 ns |  1.77 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.6277 ns | 0.0047 ns | 0.0039 ns |  1.6278 ns |  1.81 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.2025 ns | 0.0037 ns | 0.0034 ns |  1.2022 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.2985 ns | 0.0030 ns | 0.0028 ns |  1.2987 ns |  1.08 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.6924 ns | 0.0057 ns | 0.0054 ns |  0.6930 ns |  0.58 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  1.5671 ns | 0.0026 ns | 0.0024 ns |  1.5674 ns |  1.30 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  1.6390 ns | 0.0021 ns | 0.0020 ns |  1.6387 ns |  1.36 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.6930 ns | 0.0042 ns | 0.0037 ns |  1.6932 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.6719 ns | 0.0104 ns | 0.0098 ns |  1.6744 ns |  0.99 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.1047 ns | 0.0034 ns | 0.0032 ns |  1.1043 ns |  0.65 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.3048 ns | 0.0030 ns | 0.0028 ns |  2.3043 ns |  1.36 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.5533 ns | 0.0039 ns | 0.0035 ns |  2.5535 ns |  1.51 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.4205 ns | 0.0034 ns | 0.0030 ns |  0.4203 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.6778 ns | 0.0024 ns | 0.0020 ns |  0.6786 ns |  1.61 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.4774 ns | 0.0016 ns | 0.0015 ns |  0.4771 ns |  1.14 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.7200 ns | 0.0021 ns | 0.0019 ns |  0.7196 ns |  1.71 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.7169 ns | 0.0020 ns | 0.0019 ns |  0.7172 ns |  1.70 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.0575 ns | 0.0145 ns | 0.0121 ns |  1.0601 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.1450 ns | 0.0047 ns | 0.0044 ns |  1.1465 ns |  1.08 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.0763 ns | 0.0088 ns | 0.0074 ns |  1.0748 ns |  1.02 |    0.02 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.0799 ns | 0.0026 ns | 0.0024 ns |  2.0802 ns |  1.97 |    0.02 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.3894 ns | 0.0025 ns | 0.0022 ns |  1.3896 ns |  1.31 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.6647 ns | 0.0237 ns | 0.0222 ns |  1.6632 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.8439 ns | 0.0093 ns | 0.0087 ns |  1.8461 ns |  1.11 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.4265 ns | 0.0023 ns | 0.0019 ns |  1.4264 ns |  0.86 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  1.6620 ns | 0.0027 ns | 0.0025 ns |  1.6612 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.6395 ns | 0.0033 ns | 0.0029 ns |  1.6392 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  3.0027 ns | 0.0376 ns | 0.0352 ns |  3.0126 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  2.5552 ns | 0.0052 ns | 0.0049 ns |  2.5558 ns |  0.85 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  2.6658 ns | 0.0160 ns | 0.0149 ns |  2.6685 ns |  0.89 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.7014 ns | 0.0115 ns | 0.0107 ns |  2.7007 ns |  0.90 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.6568 ns | 0.0047 ns | 0.0042 ns |  2.6563 ns |  0.89 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.2693 ns | 0.0260 ns | 0.0243 ns |  1.2714 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.1468 ns | 0.0039 ns | 0.0035 ns |  1.1465 ns |  0.90 |    0.02 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.5370 ns | 0.0026 ns | 0.0024 ns |  0.5368 ns |  0.42 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  1.6180 ns | 0.0028 ns | 0.0025 ns |  1.6185 ns |  1.28 |    0.03 |     - |     - |     - |         - |
            FromULong |        net472 |  1.6600 ns | 0.0022 ns | 0.0021 ns |  1.6606 ns |  1.31 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.0705 ns | 0.0132 ns | 0.0124 ns |  2.0703 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.8670 ns | 0.0040 ns | 0.0037 ns |  1.8664 ns |  0.90 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.7296 ns | 0.0022 ns | 0.0018 ns |  1.7294 ns |  0.84 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  3.1590 ns | 0.0053 ns | 0.0050 ns |  3.1600 ns |  1.53 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  3.0800 ns | 0.0073 ns | 0.0061 ns |  3.0777 ns |  1.49 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.6824 ns | 0.0485 ns | 0.0454 ns |  3.6632 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.4947 ns | 0.0057 ns | 0.0054 ns |  3.4958 ns |  0.95 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  3.4189 ns | 0.0035 ns | 0.0031 ns |  3.4184 ns |  0.93 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.5043 ns | 0.0048 ns | 0.0040 ns |  3.5047 ns |  0.95 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.4966 ns | 0.0061 ns | 0.0054 ns |  3.4961 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  3.1045 ns | 0.0294 ns | 0.0245 ns |  3.1038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  3.9019 ns | 0.0075 ns | 0.0067 ns |  3.9026 ns |  1.26 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  3.1468 ns | 0.0042 ns | 0.0037 ns |  3.1473 ns |  1.01 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  3.4250 ns | 0.0030 ns | 0.0027 ns |  3.4251 ns |  1.10 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  3.4319 ns | 0.0054 ns | 0.0048 ns |  3.4325 ns |  1.11 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  2.4178 ns | 0.0139 ns | 0.0130 ns |  2.4222 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  2.5360 ns | 0.0046 ns | 0.0043 ns |  2.5355 ns |  1.05 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  2.8405 ns | 0.0049 ns | 0.0043 ns |  2.8416 ns |  1.18 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |  2.5942 ns | 0.0083 ns | 0.0078 ns |  2.5964 ns |  1.07 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  2.5570 ns | 0.0083 ns | 0.0074 ns |  2.5573 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  3.4942 ns | 0.0160 ns | 0.0142 ns |  3.4946 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  3.4142 ns | 0.0059 ns | 0.0055 ns |  3.4132 ns |  0.98 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  3.5597 ns | 0.0064 ns | 0.0060 ns |  3.5587 ns |  1.02 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  3.7248 ns | 0.0086 ns | 0.0077 ns |  3.7231 ns |  1.07 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  3.6965 ns | 0.0071 ns | 0.0063 ns |  3.6959 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 12.6224 ns | 0.0166 ns | 0.0155 ns | 12.6255 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 12.9175 ns | 0.0141 ns | 0.0132 ns | 12.9190 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.8002 ns | 0.0061 ns | 0.0051 ns |  5.8008 ns |  0.46 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 12.9533 ns | 0.0112 ns | 0.0099 ns | 12.9554 ns |  1.03 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 12.9785 ns | 0.0187 ns | 0.0175 ns | 12.9842 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 23.3607 ns | 0.0238 ns | 0.0222 ns | 23.3663 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 23.5852 ns | 0.0325 ns | 0.0254 ns | 23.5794 ns |  1.01 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 12.6183 ns | 0.1243 ns | 0.1163 ns | 12.6864 ns |  0.54 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 23.9195 ns | 0.0101 ns | 0.0095 ns | 23.9186 ns |  1.02 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 23.7729 ns | 0.0234 ns | 0.0195 ns | 23.7759 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.5685 ns | 0.0020 ns | 0.0018 ns |  0.5684 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.6815 ns | 0.0039 ns | 0.0035 ns |  0.6816 ns |  1.20 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.4918 ns | 0.0107 ns | 0.0100 ns |  0.4959 ns |  0.87 |    0.02 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7001 ns | 0.0028 ns | 0.0026 ns |  0.7000 ns |  1.23 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7417 ns | 0.0010 ns | 0.0009 ns |  0.7417 ns |  1.31 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4276 ns | 0.0079 ns | 0.0070 ns |  1.4258 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.3847 ns | 0.0036 ns | 0.0034 ns |  1.3845 ns |  0.97 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.3991 ns | 0.0081 ns | 0.0076 ns |  1.3967 ns |  0.98 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.4062 ns | 0.0022 ns | 0.0021 ns |  1.4056 ns |  0.99 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.3904 ns | 0.0027 ns | 0.0025 ns |  1.3906 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.2005 ns | 0.0022 ns | 0.0020 ns |  2.2003 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.2265 ns | 0.0054 ns | 0.0051 ns |  2.2248 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.1237 ns | 0.0028 ns | 0.0026 ns |  2.1227 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  2.2723 ns | 0.0113 ns | 0.0106 ns |  2.2751 ns |  1.03 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  2.2339 ns | 0.0066 ns | 0.0062 ns |  2.2340 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 45.9255 ns | 0.0833 ns | 0.0738 ns | 45.9158 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 39.3118 ns | 0.0433 ns | 0.0405 ns | 39.3032 ns |  0.86 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 10.6068 ns | 0.0144 ns | 0.0135 ns | 10.6050 ns |  0.23 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 45.6917 ns | 0.0648 ns | 0.0607 ns | 45.7063 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 45.3625 ns | 0.0718 ns | 0.0599 ns | 45.3639 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.1896 ns | 0.0027 ns | 0.0022 ns |  1.1894 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.2808 ns | 0.0034 ns | 0.0030 ns |  1.2806 ns |  1.08 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.6898 ns | 0.0019 ns | 0.0017 ns |  0.6899 ns |  0.58 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.6384 ns | 0.0021 ns | 0.0020 ns |  1.6383 ns |  1.38 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.6344 ns | 0.0035 ns | 0.0031 ns |  1.6345 ns |  1.37 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  2.1172 ns | 0.0025 ns | 0.0024 ns |  2.1170 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.6373 ns | 0.0037 ns | 0.0034 ns |  1.6365 ns |  0.77 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.3105 ns | 0.0111 ns | 0.0104 ns |  1.3132 ns |  0.62 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.3353 ns | 0.0031 ns | 0.0029 ns |  2.3350 ns |  1.10 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.3220 ns | 0.0069 ns | 0.0064 ns |  2.3221 ns |  1.10 |    0.00 |     - |     - |     - |         - |
