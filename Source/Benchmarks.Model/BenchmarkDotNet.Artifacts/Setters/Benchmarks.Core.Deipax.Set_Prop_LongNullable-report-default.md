
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
             FromBool | .NET Core 2.0 |  0.9471 ns | 0.0039 ns | 0.0030 ns |  0.9472 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9408 ns | 0.0021 ns | 0.0018 ns |  0.9408 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9428 ns | 0.0022 ns | 0.0018 ns |  0.9428 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9334 ns | 0.0097 ns | 0.0091 ns |  0.9391 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.6551 ns | 0.0044 ns | 0.0041 ns |  0.6552 ns |  0.69 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.4030 ns | 0.0029 ns | 0.0028 ns |  1.4020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.4052 ns | 0.0029 ns | 0.0027 ns |  1.4060 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1838 ns | 0.0038 ns | 0.0036 ns |  1.1826 ns |  0.84 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.9851 ns | 0.0141 ns | 0.0132 ns |  1.9826 ns |  1.41 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.9499 ns | 0.0043 ns | 0.0040 ns |  1.9506 ns |  1.39 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9438 ns | 0.0036 ns | 0.0028 ns |  0.9436 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.9780 ns | 0.0054 ns | 0.0045 ns |  0.9762 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.7242 ns | 0.0020 ns | 0.0019 ns |  0.7242 ns |  0.77 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  0.7027 ns | 0.0032 ns | 0.0030 ns |  0.7032 ns |  0.74 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.6278 ns | 0.0023 ns | 0.0021 ns |  0.6276 ns |  0.67 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.9999 ns | 0.0125 ns | 0.0117 ns |  0.9966 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.1067 ns | 0.0034 ns | 0.0030 ns |  1.1071 ns |  1.11 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1866 ns | 0.0029 ns | 0.0026 ns |  1.1866 ns |  1.19 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  2.0128 ns | 0.0039 ns | 0.0037 ns |  2.0135 ns |  2.01 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.9832 ns | 0.0073 ns | 0.0065 ns |  1.9839 ns |  1.98 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.7202 ns | 0.0016 ns | 0.0015 ns |  0.7202 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.7234 ns | 0.0019 ns | 0.0017 ns |  0.7235 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.7208 ns | 0.0027 ns | 0.0025 ns |  0.7205 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.7192 ns | 0.0078 ns | 0.0073 ns |  0.7144 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.5551 ns | 0.0035 ns | 0.0032 ns |  0.5552 ns |  0.77 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.1796 ns | 0.0027 ns | 0.0022 ns |  1.1798 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.2556 ns | 0.0097 ns | 0.0091 ns |  1.2597 ns |  1.06 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9673 ns | 0.0021 ns | 0.0018 ns |  0.9671 ns |  0.82 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.9429 ns | 0.0028 ns | 0.0026 ns |  1.9421 ns |  1.65 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.9125 ns | 0.0026 ns | 0.0025 ns |  1.9135 ns |  1.62 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.9500 ns | 0.0062 ns | 0.0058 ns |  0.9478 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7121 ns | 0.0019 ns | 0.0018 ns |  0.7119 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.7210 ns | 0.0033 ns | 0.0031 ns |  0.7212 ns |  0.76 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.7167 ns | 0.0019 ns | 0.0018 ns |  0.7169 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.5532 ns | 0.0022 ns | 0.0021 ns |  0.5535 ns |  0.58 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.9828 ns | 0.0027 ns | 0.0025 ns |  0.9825 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.1754 ns | 0.0031 ns | 0.0029 ns |  1.1753 ns |  1.20 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.0168 ns | 0.0143 ns | 0.0133 ns |  1.0246 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9519 ns | 0.0142 ns | 0.0133 ns |  1.9443 ns |  1.99 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9197 ns | 0.0033 ns | 0.0029 ns |  1.9200 ns |  1.95 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.7149 ns | 0.0013 ns | 0.0012 ns |  0.7149 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.7223 ns | 0.0104 ns | 0.0098 ns |  0.7281 ns |  1.01 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.7222 ns | 0.0017 ns | 0.0016 ns |  0.7221 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  0.7048 ns | 0.0027 ns | 0.0025 ns |  0.7053 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  0.6277 ns | 0.0020 ns | 0.0018 ns |  0.6275 ns |  0.88 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.1987 ns | 0.0109 ns | 0.0102 ns |  1.2044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.1982 ns | 0.0020 ns | 0.0018 ns |  1.1981 ns |  1.00 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1869 ns | 0.0058 ns | 0.0048 ns |  1.1865 ns |  0.99 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.0103 ns | 0.0042 ns | 0.0039 ns |  2.0112 ns |  1.68 |    0.02 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.9771 ns | 0.0031 ns | 0.0029 ns |  1.9776 ns |  1.65 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.9434 ns | 0.0022 ns | 0.0019 ns |  0.9433 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.9771 ns | 0.0021 ns | 0.0020 ns |  0.9774 ns |  1.04 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.7159 ns | 0.0029 ns | 0.0026 ns |  0.7157 ns |  0.76 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.7093 ns | 0.0083 ns | 0.0077 ns |  0.7129 ns |  0.75 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.6290 ns | 0.0036 ns | 0.0030 ns |  0.6287 ns |  0.67 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  0.9986 ns | 0.0045 ns | 0.0038 ns |  0.9985 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.1097 ns | 0.0087 ns | 0.0081 ns |  1.1141 ns |  1.11 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1116 ns | 0.0107 ns | 0.0100 ns |  1.1075 ns |  1.11 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.2597 ns | 0.0039 ns | 0.0036 ns |  2.2610 ns |  2.26 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.9780 ns | 0.0021 ns | 0.0018 ns |  1.9779 ns |  1.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.7170 ns | 0.0024 ns | 0.0022 ns |  0.7170 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.7088 ns | 0.0024 ns | 0.0022 ns |  0.7077 ns |  0.99 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.7213 ns | 0.0032 ns | 0.0030 ns |  0.7220 ns |  1.01 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  0.7238 ns | 0.0141 ns | 0.0125 ns |  0.7174 ns |  1.01 |    0.02 |     - |     - |     - |         - |
              FromInt |        net472 |  0.5663 ns | 0.0027 ns | 0.0024 ns |  0.5660 ns |  0.79 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.1757 ns | 0.0036 ns | 0.0034 ns |  1.1754 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.1859 ns | 0.0024 ns | 0.0023 ns |  1.1860 ns |  1.01 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.1003 ns | 0.0022 ns | 0.0021 ns |  1.1002 ns |  0.94 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.1660 ns | 0.0043 ns | 0.0038 ns |  2.1647 ns |  1.84 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.9225 ns | 0.0033 ns | 0.0031 ns |  1.9220 ns |  1.64 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.9606 ns | 0.0026 ns | 0.0022 ns |  0.9597 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.6868 ns | 0.0103 ns | 0.0097 ns |  0.6912 ns |  0.72 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.7339 ns | 0.0020 ns | 0.0019 ns |  0.7342 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.7175 ns | 0.0122 ns | 0.0114 ns |  0.7221 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.7148 ns | 0.0028 ns | 0.0026 ns |  0.7143 ns |  0.74 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.1217 ns | 0.0023 ns | 0.0021 ns |  1.1220 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.1540 ns | 0.0021 ns | 0.0020 ns |  1.1542 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.0949 ns | 0.0145 ns | 0.0135 ns |  1.1025 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.9485 ns | 0.0031 ns | 0.0029 ns |  1.9489 ns |  1.74 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.9904 ns | 0.0028 ns | 0.0023 ns |  1.9907 ns |  1.77 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  0.7200 ns | 0.0028 ns | 0.0024 ns |  0.7198 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  0.6727 ns | 0.0024 ns | 0.0022 ns |  0.6727 ns |  0.93 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.6579 ns | 0.0022 ns | 0.0021 ns |  0.6578 ns |  0.91 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  0.7111 ns | 0.0020 ns | 0.0018 ns |  0.7116 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  0.6982 ns | 0.0019 ns | 0.0018 ns |  0.6980 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.1384 ns | 0.0051 ns | 0.0048 ns |  1.1386 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.1316 ns | 0.0030 ns | 0.0027 ns |  1.1320 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.4556 ns | 0.0042 ns | 0.0035 ns |  1.4556 ns |  1.28 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  1.1162 ns | 0.0118 ns | 0.0110 ns |  1.1208 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  1.5385 ns | 0.0028 ns | 0.0025 ns |  1.5380 ns |  1.35 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.4518 ns | 0.0023 ns | 0.0020 ns |  1.4520 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.3847 ns | 0.0028 ns | 0.0026 ns |  1.3851 ns |  0.95 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.9457 ns | 0.0101 ns | 0.0094 ns |  0.9501 ns |  0.65 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  1.7380 ns | 0.0030 ns | 0.0026 ns |  1.7385 ns |  1.20 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.7462 ns | 0.0058 ns | 0.0052 ns |  1.7480 ns |  1.20 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.0368 ns | 0.0040 ns | 0.0035 ns |  2.0362 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  2.0094 ns | 0.0034 ns | 0.0032 ns |  2.0089 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.7099 ns | 0.0037 ns | 0.0035 ns |  1.7102 ns |  0.84 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.9954 ns | 0.0062 ns | 0.0058 ns |  2.9955 ns |  1.47 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  3.0639 ns | 0.0053 ns | 0.0050 ns |  3.0653 ns |  1.50 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.4471 ns | 0.0069 ns | 0.0065 ns |  3.4463 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  2.2095 ns | 0.0057 ns | 0.0047 ns |  2.2088 ns |  0.64 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  1.9468 ns | 0.0039 ns | 0.0032 ns |  1.9466 ns |  0.56 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.3556 ns | 0.0325 ns | 0.0304 ns |  3.3388 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.3294 ns | 0.0047 ns | 0.0039 ns |  3.3297 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  4.1298 ns | 0.0040 ns | 0.0037 ns |  4.1291 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  2.8301 ns | 0.0050 ns | 0.0047 ns |  2.8303 ns |  0.69 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  2.4601 ns | 0.0282 ns | 0.0263 ns |  2.4771 ns |  0.60 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  3.9664 ns | 0.0052 ns | 0.0049 ns |  3.9676 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.0318 ns | 0.0038 ns | 0.0032 ns |  4.0327 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  2.9962 ns | 0.0046 ns | 0.0043 ns |  2.9953 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  1.9284 ns | 0.0043 ns | 0.0041 ns |  1.9303 ns |  0.64 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  1.9293 ns | 0.0025 ns | 0.0022 ns |  1.9297 ns |  0.64 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.2606 ns | 0.0044 ns | 0.0041 ns |  3.2614 ns |  1.09 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.2630 ns | 0.0028 ns | 0.0026 ns |  3.2631 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  4.1011 ns | 0.0053 ns | 0.0049 ns |  4.1002 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  3.3493 ns | 0.0034 ns | 0.0030 ns |  3.3491 ns |  0.82 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  2.9713 ns | 0.0058 ns | 0.0051 ns |  2.9714 ns |  0.72 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  4.6866 ns | 0.0312 ns | 0.0292 ns |  4.6724 ns |  1.14 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  4.7008 ns | 0.0045 ns | 0.0035 ns |  4.7009 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.3411 ns | 0.0068 ns | 0.0063 ns | 13.3407 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.4241 ns | 0.0659 ns | 0.0616 ns | 13.4555 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.7250 ns | 0.0301 ns | 0.0281 ns |  5.7391 ns |  0.43 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.4762 ns | 0.0095 ns | 0.0085 ns | 13.4774 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.5056 ns | 0.0174 ns | 0.0155 ns | 13.5067 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 24.2337 ns | 0.0214 ns | 0.0190 ns | 24.2346 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 24.2173 ns | 0.0300 ns | 0.0266 ns | 24.2196 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 13.1873 ns | 0.0112 ns | 0.0104 ns | 13.1876 ns |  0.54 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 25.0327 ns | 0.0380 ns | 0.0355 ns | 25.0452 ns |  1.03 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 25.0219 ns | 0.0244 ns | 0.0228 ns | 25.0183 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9494 ns | 0.0021 ns | 0.0019 ns |  0.9487 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.6959 ns | 0.0019 ns | 0.0018 ns |  0.6963 ns |  0.73 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.9580 ns | 0.0028 ns | 0.0025 ns |  0.9578 ns |  1.01 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.9718 ns | 0.0063 ns | 0.0059 ns |  0.9743 ns |  1.02 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.9285 ns | 0.0026 ns | 0.0023 ns |  0.9292 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.6065 ns | 0.0031 ns | 0.0029 ns |  1.6065 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6320 ns | 0.0084 ns | 0.0070 ns |  1.6357 ns |  1.02 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4809 ns | 0.0029 ns | 0.0027 ns |  1.4822 ns |  0.92 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6390 ns | 0.0029 ns | 0.0027 ns |  1.6388 ns |  1.02 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.7998 ns | 0.0030 ns | 0.0028 ns |  1.7992 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 10.8124 ns | 0.0080 ns | 0.0075 ns | 10.8135 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 14.3774 ns | 0.0133 ns | 0.0124 ns | 14.3786 ns |  1.33 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 15.0665 ns | 0.0585 ns | 0.0547 ns | 15.0422 ns |  1.39 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 | 13.3200 ns | 0.0611 ns | 0.0572 ns | 13.2981 ns |  1.23 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 | 13.2312 ns | 0.0097 ns | 0.0081 ns | 13.2302 ns |  1.22 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 48.1715 ns | 0.0583 ns | 0.0545 ns | 48.1628 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 40.5911 ns | 0.0543 ns | 0.0508 ns | 40.5792 ns |  0.84 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 11.1710 ns | 0.0420 ns | 0.0393 ns | 11.1783 ns |  0.23 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 47.1358 ns | 0.0867 ns | 0.0769 ns | 47.1149 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 47.5415 ns | 0.1009 ns | 0.0944 ns | 47.5534 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.9458 ns | 0.0018 ns | 0.0016 ns |  0.9458 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.6756 ns | 0.0019 ns | 0.0018 ns |  0.6755 ns |  0.71 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.7432 ns | 0.0024 ns | 0.0022 ns |  0.7428 ns |  0.79 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.7117 ns | 0.0058 ns | 0.0048 ns |  0.7129 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.7100 ns | 0.0023 ns | 0.0021 ns |  0.7099 ns |  0.75 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.1012 ns | 0.0020 ns | 0.0019 ns |  1.1015 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.1557 ns | 0.0019 ns | 0.0018 ns |  1.1558 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.1168 ns | 0.0027 ns | 0.0024 ns |  1.1168 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.9603 ns | 0.0046 ns | 0.0040 ns |  1.9590 ns |  1.78 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.9676 ns | 0.0069 ns | 0.0057 ns |  1.9689 ns |  1.79 |    0.01 |     - |     - |     - |         - |
