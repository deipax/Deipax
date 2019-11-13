
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
             FromBool | .NET Core 2.0 |  0.8769 ns | 0.0067 ns | 0.0059 ns |  0.8753 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9169 ns | 0.0128 ns | 0.0119 ns |  0.9110 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9544 ns | 0.0027 ns | 0.0025 ns |  0.9548 ns |  1.09 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9022 ns | 0.0072 ns | 0.0067 ns |  0.8994 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  1.1618 ns | 0.0037 ns | 0.0035 ns |  1.1621 ns |  1.32 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  0.9755 ns | 0.0049 ns | 0.0041 ns |  0.9743 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  0.9425 ns | 0.0111 ns | 0.0104 ns |  0.9430 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.0040 ns | 0.0031 ns | 0.0027 ns |  1.0037 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.9231 ns | 0.0040 ns | 0.0031 ns |  1.9248 ns |  1.97 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.9512 ns | 0.0021 ns | 0.0020 ns |  1.9512 ns |  2.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.6611 ns | 0.0039 ns | 0.0030 ns |  0.6618 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.6456 ns | 0.0035 ns | 0.0031 ns |  0.6467 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.5824 ns | 0.0091 ns | 0.0085 ns |  0.5785 ns |  0.88 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.6331 ns | 0.0142 ns | 0.0133 ns |  0.6391 ns |  0.96 |    0.02 |     - |     - |     - |         - |
             FromChar |        net472 |  1.2937 ns | 0.0029 ns | 0.0026 ns |  1.2937 ns |  1.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.6925 ns | 0.0151 ns | 0.0126 ns |  0.6873 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.9720 ns | 0.0520 ns | 0.0486 ns |  0.9497 ns |  1.41 |    0.09 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.8048 ns | 0.0022 ns | 0.0021 ns |  0.8043 ns |  1.16 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  0.8983 ns | 0.0032 ns | 0.0030 ns |  0.8989 ns |  1.30 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.0026 ns | 0.0048 ns | 0.0045 ns |  1.0019 ns |  1.45 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.5640 ns | 0.0093 ns | 0.0087 ns |  0.5666 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.5900 ns | 0.0175 ns | 0.0155 ns |  0.5835 ns |  1.05 |    0.03 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.5897 ns | 0.0028 ns | 0.0025 ns |  0.5901 ns |  1.05 |    0.02 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.6609 ns | 0.0028 ns | 0.0026 ns |  0.6609 ns |  1.17 |    0.02 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.9351 ns | 0.0041 ns | 0.0038 ns |  0.9365 ns |  1.66 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.0000 ns | 0.0103 ns | 0.0086 ns |  0.9984 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.9201 ns | 0.0028 ns | 0.0025 ns |  0.9197 ns |  0.92 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9727 ns | 0.0027 ns | 0.0024 ns |  0.9734 ns |  0.97 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.1534 ns | 0.0179 ns | 0.0168 ns |  2.1606 ns |  2.16 |    0.02 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.5130 ns | 0.0072 ns | 0.0068 ns |  2.5132 ns |  2.51 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.6467 ns | 0.0109 ns | 0.0102 ns |  0.6443 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.6735 ns | 0.0086 ns | 0.0080 ns |  0.6697 ns |  1.04 |    0.03 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.6994 ns | 0.0024 ns | 0.0022 ns |  0.6994 ns |  1.08 |    0.02 |     - |     - |     - |         - |
             FromByte |        net461 |  0.5859 ns | 0.0034 ns | 0.0032 ns |  0.5855 ns |  0.91 |    0.02 |     - |     - |     - |         - |
             FromByte |        net472 |  0.7023 ns | 0.0033 ns | 0.0030 ns |  0.7024 ns |  1.09 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.0234 ns | 0.0178 ns | 0.0167 ns |  1.0146 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9427 ns | 0.0041 ns | 0.0036 ns |  0.9427 ns |  0.92 |    0.02 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9827 ns | 0.0030 ns | 0.0027 ns |  0.9834 ns |  0.96 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9361 ns | 0.0032 ns | 0.0028 ns |  1.9362 ns |  1.89 |    0.03 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  2.0468 ns | 0.0027 ns | 0.0023 ns |  2.0471 ns |  2.00 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.6574 ns | 0.0244 ns | 0.0229 ns |  0.6492 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.6810 ns | 0.0027 ns | 0.0026 ns |  0.6802 ns |  1.04 |    0.04 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.7166 ns | 0.0028 ns | 0.0024 ns |  0.7166 ns |  1.09 |    0.04 |     - |     - |     - |         - |
            FromShort |        net461 |  0.6483 ns | 0.0034 ns | 0.0030 ns |  0.6478 ns |  0.99 |    0.04 |     - |     - |     - |         - |
            FromShort |        net472 |  0.9299 ns | 0.0058 ns | 0.0054 ns |  0.9299 ns |  1.42 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.0277 ns | 0.0131 ns | 0.0116 ns |  1.0243 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.1291 ns | 0.0033 ns | 0.0026 ns |  1.1292 ns |  1.10 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1223 ns | 0.0043 ns | 0.0036 ns |  1.1209 ns |  1.09 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.8826 ns | 0.0048 ns | 0.0043 ns |  1.8832 ns |  1.83 |    0.02 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.9285 ns | 0.0056 ns | 0.0052 ns |  1.9299 ns |  1.88 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.6705 ns | 0.0103 ns | 0.0096 ns |  0.6679 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.6420 ns | 0.0028 ns | 0.0027 ns |  0.6422 ns |  0.96 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.7594 ns | 0.0022 ns | 0.0020 ns |  0.7595 ns |  1.13 |    0.02 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.6305 ns | 0.0023 ns | 0.0021 ns |  0.6309 ns |  0.94 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.7309 ns | 0.0046 ns | 0.0043 ns |  0.7296 ns |  1.09 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.0100 ns | 0.0190 ns | 0.0177 ns |  1.0049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.1104 ns | 0.0088 ns | 0.0082 ns |  1.1123 ns |  1.10 |    0.02 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1291 ns | 0.0039 ns | 0.0032 ns |  1.1299 ns |  1.12 |    0.02 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.0353 ns | 0.0016 ns | 0.0014 ns |  2.0353 ns |  2.02 |    0.04 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.9137 ns | 0.0044 ns | 0.0039 ns |  1.9140 ns |  1.90 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.5500 ns | 0.0047 ns | 0.0039 ns |  0.5494 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.9715 ns | 0.0063 ns | 0.0056 ns |  0.9700 ns |  1.77 |    0.02 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.7642 ns | 0.0023 ns | 0.0022 ns |  0.7638 ns |  1.39 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  0.6591 ns | 0.0124 ns | 0.0116 ns |  0.6628 ns |  1.20 |    0.03 |     - |     - |     - |         - |
              FromInt |        net472 |  0.7263 ns | 0.0031 ns | 0.0029 ns |  0.7263 ns |  1.32 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.0034 ns | 0.0109 ns | 0.0097 ns |  1.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.0555 ns | 0.0026 ns | 0.0022 ns |  1.0550 ns |  1.05 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.1098 ns | 0.0039 ns | 0.0030 ns |  1.1094 ns |  1.11 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.8816 ns | 0.0043 ns | 0.0040 ns |  1.8811 ns |  1.88 |    0.02 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.9041 ns | 0.0031 ns | 0.0029 ns |  1.9032 ns |  1.90 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.6631 ns | 0.0120 ns | 0.0112 ns |  0.6590 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.9807 ns | 0.0027 ns | 0.0024 ns |  0.9805 ns |  1.48 |    0.03 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.9596 ns | 0.0119 ns | 0.0106 ns |  0.9559 ns |  1.45 |    0.03 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.7574 ns | 0.0026 ns | 0.0023 ns |  0.7576 ns |  1.14 |    0.02 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.7803 ns | 0.0025 ns | 0.0022 ns |  0.7800 ns |  1.18 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.0305 ns | 0.0036 ns | 0.0034 ns |  1.0306 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.1718 ns | 0.0046 ns | 0.0038 ns |  1.1718 ns |  1.14 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.2090 ns | 0.0093 ns | 0.0083 ns |  1.2101 ns |  1.17 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.9216 ns | 0.0193 ns | 0.0181 ns |  1.9290 ns |  1.86 |    0.02 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.9001 ns | 0.0030 ns | 0.0028 ns |  1.8993 ns |  1.84 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  0.6943 ns | 0.0124 ns | 0.0110 ns |  0.6895 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  0.9295 ns | 0.0073 ns | 0.0061 ns |  0.9299 ns |  1.34 |    0.03 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.9289 ns | 0.0022 ns | 0.0020 ns |  0.9291 ns |  1.34 |    0.02 |     - |     - |     - |         - |
             FromLong |        net461 |  0.7365 ns | 0.0031 ns | 0.0024 ns |  0.7369 ns |  1.06 |    0.02 |     - |     - |     - |         - |
             FromLong |        net472 |  1.3111 ns | 0.0033 ns | 0.0031 ns |  1.3102 ns |  1.89 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.7408 ns | 0.0251 ns | 0.0222 ns |  1.7332 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.7133 ns | 0.0025 ns | 0.0021 ns |  1.7135 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.6995 ns | 0.0036 ns | 0.0034 ns |  1.6994 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.1315 ns | 0.0245 ns | 0.0229 ns |  2.1410 ns |  1.23 |    0.02 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.0805 ns | 0.0051 ns | 0.0045 ns |  2.0808 ns |  1.20 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  0.9362 ns | 0.0193 ns | 0.0181 ns |  0.9349 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.1747 ns | 0.0100 ns | 0.0089 ns |  1.1715 ns |  1.26 |    0.03 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.1645 ns | 0.0027 ns | 0.0025 ns |  1.1646 ns |  1.24 |    0.02 |     - |     - |     - |         - |
            FromULong |        net461 |  1.1583 ns | 0.0035 ns | 0.0028 ns |  1.1586 ns |  1.24 |    0.02 |     - |     - |     - |         - |
            FromULong |        net472 |  1.1373 ns | 0.0018 ns | 0.0016 ns |  1.1374 ns |  1.22 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.8160 ns | 0.0596 ns | 0.0557 ns |  1.8292 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.8670 ns | 0.0052 ns | 0.0044 ns |  1.8664 ns |  1.02 |    0.03 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  2.2677 ns | 0.0706 ns | 0.0867 ns |  2.2655 ns |  1.26 |    0.04 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.1122 ns | 0.0045 ns | 0.0040 ns |  2.1126 ns |  1.16 |    0.03 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.1056 ns | 0.0046 ns | 0.0041 ns |  2.1047 ns |  1.16 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  0.5259 ns | 0.0096 ns | 0.0085 ns |  0.5231 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  0.7189 ns | 0.0030 ns | 0.0028 ns |  0.7192 ns |  1.37 |    0.02 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  0.7257 ns | 0.0040 ns | 0.0038 ns |  0.7252 ns |  1.38 |    0.02 |     - |     - |     - |         - |
            FromFloat |        net461 |  0.7308 ns | 0.0113 ns | 0.0105 ns |  0.7242 ns |  1.39 |    0.03 |     - |     - |     - |         - |
            FromFloat |        net472 |  1.3090 ns | 0.0092 ns | 0.0086 ns |  1.3107 ns |  2.49 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  0.6867 ns | 0.0160 ns | 0.0150 ns |  0.6807 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  0.7280 ns | 0.0025 ns | 0.0023 ns |  0.7283 ns |  1.06 |    0.02 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  0.7028 ns | 0.0034 ns | 0.0030 ns |  0.7031 ns |  1.02 |    0.02 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  0.9482 ns | 0.0030 ns | 0.0028 ns |  0.9478 ns |  1.38 |    0.03 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  0.8867 ns | 0.0030 ns | 0.0027 ns |  0.8862 ns |  1.29 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  0.7116 ns | 0.0035 ns | 0.0031 ns |  0.7126 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  0.7344 ns | 0.0022 ns | 0.0021 ns |  0.7339 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  0.7129 ns | 0.0032 ns | 0.0030 ns |  0.7125 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |  0.9495 ns | 0.0029 ns | 0.0027 ns |  0.9498 ns |  1.33 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  0.8886 ns | 0.0038 ns | 0.0036 ns |  0.8893 ns |  1.25 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.5602 ns | 0.0062 ns | 0.0052 ns |  1.5594 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.7354 ns | 0.0103 ns | 0.0097 ns |  1.7314 ns |  1.11 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.6986 ns | 0.0057 ns | 0.0051 ns |  1.6970 ns |  1.09 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.1755 ns | 0.0173 ns | 0.0162 ns |  2.1670 ns |  1.39 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.1168 ns | 0.0080 ns | 0.0074 ns |  2.1181 ns |  1.36 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 10.5205 ns | 0.0397 ns | 0.0352 ns | 10.5195 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |  9.9949 ns | 0.0115 ns | 0.0108 ns |  9.9930 ns |  0.95 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.5540 ns | 0.0100 ns | 0.0094 ns |  5.5532 ns |  0.53 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 10.6597 ns | 0.0227 ns | 0.0213 ns | 10.6580 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 10.0374 ns | 0.0131 ns | 0.0116 ns | 10.0390 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.2578 ns | 0.0466 ns | 0.0413 ns |  8.2421 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  8.5684 ns | 0.0766 ns | 0.0717 ns |  8.6033 ns |  1.04 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  2.6114 ns | 0.0073 ns | 0.0068 ns |  2.6141 ns |  0.32 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  8.7843 ns | 0.0156 ns | 0.0130 ns |  8.7835 ns |  1.06 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  8.8648 ns | 0.0109 ns | 0.0102 ns |  8.8676 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6679 ns | 0.0040 ns | 0.0031 ns |  0.6668 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  1.3378 ns | 0.0036 ns | 0.0033 ns |  1.3365 ns |  2.00 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7393 ns | 0.0033 ns | 0.0030 ns |  0.7390 ns |  1.11 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.9381 ns | 0.0127 ns | 0.0119 ns |  0.9437 ns |  1.41 |    0.02 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.8907 ns | 0.0066 ns | 0.0062 ns |  0.8918 ns |  1.33 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4821 ns | 0.0080 ns | 0.0067 ns |  1.4795 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6603 ns | 0.0027 ns | 0.0025 ns |  1.6607 ns |  1.12 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4384 ns | 0.0054 ns | 0.0048 ns |  1.4383 ns |  0.97 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6557 ns | 0.0025 ns | 0.0024 ns |  1.6561 ns |  1.12 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 | 10.8263 ns | 0.0132 ns | 0.0124 ns | 10.8241 ns |  7.31 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  3.3776 ns | 0.0584 ns | 0.0518 ns |  3.3693 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  3.1661 ns | 0.0067 ns | 0.0063 ns |  3.1650 ns |  0.94 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  3.1129 ns | 0.0065 ns | 0.0054 ns |  3.1128 ns |  0.92 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  2.9542 ns | 0.0079 ns | 0.0070 ns |  2.9515 ns |  0.87 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  2.8973 ns | 0.0081 ns | 0.0072 ns |  2.8978 ns |  0.86 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  1.9376 ns | 0.0143 ns | 0.0134 ns |  1.9346 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  2.0088 ns | 0.0083 ns | 0.0077 ns |  2.0085 ns |  1.04 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.8470 ns | 0.0035 ns | 0.0033 ns |  1.8473 ns |  0.95 |    0.01 |     - |     - |     - |         - |
           FromString |        net461 |  1.9477 ns | 0.0122 ns | 0.0115 ns |  1.9523 ns |  1.01 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 |  1.9382 ns | 0.0032 ns | 0.0030 ns |  1.9384 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.6627 ns | 0.0090 ns | 0.0079 ns |  0.6606 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.9474 ns | 0.0017 ns | 0.0016 ns |  0.9466 ns |  1.43 |    0.02 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.9348 ns | 0.0038 ns | 0.0033 ns |  0.9343 ns |  1.41 |    0.02 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.8021 ns | 0.0042 ns | 0.0037 ns |  0.8017 ns |  1.21 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.8799 ns | 0.0027 ns | 0.0025 ns |  0.8792 ns |  1.33 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.1096 ns | 0.0078 ns | 0.0069 ns |  1.1078 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.1785 ns | 0.0028 ns | 0.0026 ns |  1.1779 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.1429 ns | 0.0034 ns | 0.0032 ns |  1.1427 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.9152 ns | 0.0052 ns | 0.0043 ns |  1.9153 ns |  1.73 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.8815 ns | 0.0084 ns | 0.0079 ns |  1.8810 ns |  1.70 |    0.01 |     - |     - |     - |         - |
