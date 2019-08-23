
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
             FromBool | .NET Core 2.0 |  0.7066 ns | 0.0057 ns | 0.0048 ns |  0.7054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9212 ns | 0.0026 ns | 0.0024 ns |  0.9215 ns |  1.30 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.7131 ns | 0.0020 ns | 0.0019 ns |  0.7134 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6707 ns | 0.0026 ns | 0.0025 ns |  0.6705 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9372 ns | 0.0028 ns | 0.0025 ns |  0.9380 ns |  1.33 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1588 ns | 0.0056 ns | 0.0053 ns |  1.1597 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1691 ns | 0.0020 ns | 0.0019 ns |  1.1693 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9574 ns | 0.0034 ns | 0.0031 ns |  0.9576 ns |  0.83 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.0557 ns | 0.0147 ns | 0.0138 ns |  2.0473 ns |  1.77 |    0.02 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.1804 ns | 0.0037 ns | 0.0035 ns |  2.1795 ns |  1.88 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.6935 ns | 0.0023 ns | 0.0022 ns |  0.6935 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.6974 ns | 0.0022 ns | 0.0020 ns |  0.6981 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.5870 ns | 0.0031 ns | 0.0029 ns |  0.5877 ns |  0.85 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  0.6203 ns | 0.0017 ns | 0.0016 ns |  0.6209 ns |  0.89 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.7325 ns | 0.0027 ns | 0.0025 ns |  0.7328 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.1124 ns | 0.0044 ns | 0.0041 ns |  1.1127 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.0987 ns | 0.0068 ns | 0.0060 ns |  1.0970 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.5685 ns | 0.0033 ns | 0.0029 ns |  1.5678 ns |  1.41 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.9672 ns | 0.0021 ns | 0.0018 ns |  1.9674 ns |  1.77 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.0095 ns | 0.0177 ns | 0.0165 ns |  2.0188 ns |  1.81 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.3159 ns | 0.0030 ns | 0.0028 ns |  1.3159 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.3819 ns | 0.0030 ns | 0.0028 ns |  1.3825 ns |  1.05 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6953 ns | 0.0029 ns | 0.0026 ns |  0.6954 ns |  0.53 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.7446 ns | 0.0154 ns | 0.0144 ns |  1.7527 ns |  1.33 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.7652 ns | 0.0022 ns | 0.0020 ns |  1.7650 ns |  1.34 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.8721 ns | 0.0047 ns | 0.0037 ns |  1.8726 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.8265 ns | 0.0099 ns | 0.0093 ns |  1.8290 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9463 ns | 0.0015 ns | 0.0014 ns |  0.9461 ns |  0.51 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.9599 ns | 0.0068 ns | 0.0064 ns |  2.9565 ns |  1.58 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  3.3980 ns | 0.0049 ns | 0.0045 ns |  3.3985 ns |  1.81 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.9614 ns | 0.0022 ns | 0.0021 ns |  0.9611 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7108 ns | 0.0023 ns | 0.0021 ns |  0.7104 ns |  0.74 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.5556 ns | 0.0020 ns | 0.0019 ns |  0.5553 ns |  0.58 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  0.5518 ns | 0.0030 ns | 0.0027 ns |  0.5527 ns |  0.57 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.7190 ns | 0.0058 ns | 0.0054 ns |  0.7209 ns |  0.75 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.9963 ns | 0.0022 ns | 0.0019 ns |  0.9971 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9666 ns | 0.0111 ns | 0.0104 ns |  0.9707 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9615 ns | 0.0034 ns | 0.0029 ns |  0.9625 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9870 ns | 0.0199 ns | 0.0186 ns |  1.9946 ns |  2.00 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  2.0497 ns | 0.0039 ns | 0.0036 ns |  2.0499 ns |  2.06 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.3192 ns | 0.0031 ns | 0.0029 ns |  1.3195 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.3838 ns | 0.0087 ns | 0.0077 ns |  1.3827 ns |  1.05 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.6152 ns | 0.0024 ns | 0.0022 ns |  0.6153 ns |  0.47 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.7343 ns | 0.0052 ns | 0.0048 ns |  1.7349 ns |  1.31 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  1.7635 ns | 0.0027 ns | 0.0026 ns |  1.7638 ns |  1.34 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.9655 ns | 0.0025 ns | 0.0023 ns |  1.9647 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.7774 ns | 0.0038 ns | 0.0036 ns |  1.7781 ns |  0.90 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.0885 ns | 0.0020 ns | 0.0019 ns |  1.0885 ns |  0.55 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.7672 ns | 0.0061 ns | 0.0057 ns |  2.7666 ns |  1.41 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.8467 ns | 0.0197 ns | 0.0184 ns |  2.8543 ns |  1.45 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.6946 ns | 0.0021 ns | 0.0019 ns |  0.6942 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.7081 ns | 0.0014 ns | 0.0013 ns |  0.7082 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.5511 ns | 0.0030 ns | 0.0026 ns |  0.5519 ns |  0.79 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.6178 ns | 0.0028 ns | 0.0025 ns |  0.6175 ns |  0.89 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.7328 ns | 0.0022 ns | 0.0020 ns |  0.7324 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  0.6392 ns | 0.0030 ns | 0.0028 ns |  0.6391 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  0.7201 ns | 0.0019 ns | 0.0015 ns |  0.7203 ns |  1.13 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  0.5926 ns | 0.0019 ns | 0.0017 ns |  0.5924 ns |  0.93 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  0.5267 ns | 0.0030 ns | 0.0027 ns |  0.5260 ns |  0.82 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  0.7219 ns | 0.0021 ns | 0.0020 ns |  0.7219 ns |  1.13 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.7745 ns | 0.0031 ns | 0.0028 ns |  1.7749 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  2.1001 ns | 0.0035 ns | 0.0033 ns |  2.1003 ns |  1.18 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.6613 ns | 0.0037 ns | 0.0033 ns |  1.6611 ns |  0.94 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7596 ns | 0.0029 ns | 0.0027 ns |  1.7593 ns |  0.99 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7947 ns | 0.0101 ns | 0.0095 ns |  1.7956 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.5702 ns | 0.0044 ns | 0.0039 ns |  2.5712 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  2.6554 ns | 0.0045 ns | 0.0038 ns |  2.6544 ns |  1.03 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  2.2218 ns | 0.0040 ns | 0.0038 ns |  2.2207 ns |  0.86 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.8038 ns | 0.0067 ns | 0.0063 ns |  2.8059 ns |  1.09 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.8538 ns | 0.0041 ns | 0.0039 ns |  2.8554 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.4463 ns | 0.0034 ns | 0.0030 ns |  1.4468 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.4158 ns | 0.0116 ns | 0.0109 ns |  1.4119 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.7485 ns | 0.0025 ns | 0.0022 ns |  0.7484 ns |  0.52 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.7856 ns | 0.0024 ns | 0.0022 ns |  1.7856 ns |  1.23 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.7584 ns | 0.0032 ns | 0.0030 ns |  1.7590 ns |  1.22 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  2.3328 ns | 0.0116 ns | 0.0109 ns |  2.3354 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.9150 ns | 0.0036 ns | 0.0032 ns |  1.9156 ns |  0.82 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.1794 ns | 0.0026 ns | 0.0022 ns |  1.1802 ns |  0.51 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  3.3076 ns | 0.0047 ns | 0.0042 ns |  3.3080 ns |  1.42 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.7735 ns | 0.0275 ns | 0.0257 ns |  2.7884 ns |  1.19 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.8112 ns | 0.0028 ns | 0.0026 ns |  1.8118 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.8182 ns | 0.0023 ns | 0.0021 ns |  1.8187 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.7056 ns | 0.0130 ns | 0.0121 ns |  1.7111 ns |  0.94 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  1.7299 ns | 0.0031 ns | 0.0028 ns |  1.7302 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  1.7327 ns | 0.0037 ns | 0.0033 ns |  1.7326 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  2.9207 ns | 0.0052 ns | 0.0049 ns |  2.9191 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  2.9404 ns | 0.0042 ns | 0.0039 ns |  2.9412 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  2.6123 ns | 0.0058 ns | 0.0052 ns |  2.6115 ns |  0.89 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  3.1618 ns | 0.0063 ns | 0.0058 ns |  3.1623 ns |  1.08 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  3.0908 ns | 0.0050 ns | 0.0047 ns |  3.0900 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.9481 ns | 0.0039 ns | 0.0032 ns |  1.9477 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.7117 ns | 0.0030 ns | 0.0028 ns |  1.7113 ns |  0.88 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.6684 ns | 0.0087 ns | 0.0081 ns |  1.6724 ns |  0.86 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.7565 ns | 0.0015 ns | 0.0014 ns |  1.7571 ns |  0.90 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.7590 ns | 0.0038 ns | 0.0036 ns |  1.7589 ns |  0.90 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.9316 ns | 0.0113 ns | 0.0106 ns |  2.9302 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  3.0070 ns | 0.0221 ns | 0.0206 ns |  3.0159 ns |  1.03 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  2.6073 ns | 0.0032 ns | 0.0030 ns |  2.6073 ns |  0.89 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  3.0306 ns | 0.0040 ns | 0.0038 ns |  3.0296 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  3.0014 ns | 0.0038 ns | 0.0032 ns |  3.0010 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.9422 ns | 0.0065 ns | 0.0061 ns |  3.9421 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  4.0057 ns | 0.0050 ns | 0.0044 ns |  4.0062 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  4.1827 ns | 0.0121 ns | 0.0107 ns |  4.1826 ns |  1.06 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.7975 ns | 0.0216 ns | 0.0169 ns |  3.8047 ns |  0.96 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.7626 ns | 0.0050 ns | 0.0044 ns |  3.7616 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  4.8732 ns | 0.0057 ns | 0.0054 ns |  4.8751 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  4.7557 ns | 0.0067 ns | 0.0059 ns |  4.7563 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  4.4855 ns | 0.0255 ns | 0.0199 ns |  4.4807 ns |  0.92 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  4.7205 ns | 0.0083 ns | 0.0078 ns |  4.7221 ns |  0.97 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.6423 ns | 0.0050 ns | 0.0044 ns |  4.6412 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.9705 ns | 0.0110 ns | 0.0097 ns |  3.9708 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.5333 ns | 0.0053 ns | 0.0049 ns |  3.5326 ns |  0.89 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  4.1879 ns | 0.0058 ns | 0.0049 ns |  4.1876 ns |  1.05 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.7163 ns | 0.0059 ns | 0.0055 ns |  3.7164 ns |  0.94 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.7855 ns | 0.0130 ns | 0.0122 ns |  3.7848 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  4.6372 ns | 0.0079 ns | 0.0074 ns |  4.6372 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  4.7947 ns | 0.0087 ns | 0.0068 ns |  4.7969 ns |  1.03 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  4.9965 ns | 0.0167 ns | 0.0156 ns |  5.0030 ns |  1.08 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  5.7400 ns | 0.0077 ns | 0.0072 ns |  5.7399 ns |  1.24 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  6.1581 ns | 0.0064 ns | 0.0060 ns |  6.1592 ns |  1.33 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.5544 ns | 0.0191 ns | 0.0169 ns | 13.5535 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.7032 ns | 0.0204 ns | 0.0191 ns | 13.7025 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  7.4842 ns | 0.1754 ns | 0.2401 ns |  7.3605 ns |  0.56 |    0.02 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.9498 ns | 0.0240 ns | 0.0224 ns | 13.9450 ns |  1.03 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 17.0925 ns | 0.0276 ns | 0.0258 ns | 17.0875 ns |  1.26 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 24.5134 ns | 0.0285 ns | 0.0267 ns | 24.5208 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 24.5506 ns | 0.0219 ns | 0.0205 ns | 24.5533 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 14.0833 ns | 0.0721 ns | 0.0674 ns | 14.0425 ns |  0.57 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 24.7572 ns | 0.0415 ns | 0.0368 ns | 24.7612 ns |  1.01 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 24.9747 ns | 0.1055 ns | 0.0987 ns | 24.9984 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6954 ns | 0.0025 ns | 0.0021 ns |  0.6957 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.9595 ns | 0.0029 ns | 0.0027 ns |  0.9592 ns |  1.38 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7515 ns | 0.0058 ns | 0.0054 ns |  0.7526 ns |  1.08 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.6879 ns | 0.0027 ns | 0.0025 ns |  0.6880 ns |  0.99 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.6760 ns | 0.0026 ns | 0.0023 ns |  0.6760 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4832 ns | 0.0116 ns | 0.0108 ns |  1.4881 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6379 ns | 0.0032 ns | 0.0030 ns |  1.6381 ns |  1.10 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4449 ns | 0.0033 ns | 0.0031 ns |  1.4455 ns |  0.97 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6525 ns | 0.0043 ns | 0.0038 ns |  1.6533 ns |  1.11 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6310 ns | 0.0049 ns | 0.0046 ns |  1.6299 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  9.8245 ns | 0.0120 ns | 0.0112 ns |  9.8244 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 14.0646 ns | 0.0205 ns | 0.0181 ns | 14.0627 ns |  1.43 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 14.9571 ns | 0.0441 ns | 0.0368 ns | 14.9702 ns |  1.52 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 | 12.9459 ns | 0.0107 ns | 0.0100 ns | 12.9415 ns |  1.32 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 13.5085 ns | 0.0561 ns | 0.0497 ns | 13.5239 ns |  1.37 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 47.9446 ns | 0.0680 ns | 0.0603 ns | 47.9312 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 41.5116 ns | 0.0586 ns | 0.0548 ns | 41.5279 ns |  0.87 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  8.6122 ns | 0.0237 ns | 0.0197 ns |  8.6121 ns |  0.18 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 47.7708 ns | 0.0941 ns | 0.0880 ns | 47.7535 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 46.6968 ns | 0.0773 ns | 0.0723 ns | 46.7179 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.8389 ns | 0.0083 ns | 0.0078 ns |  1.8406 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.8695 ns | 0.0067 ns | 0.0062 ns |  1.8675 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.6983 ns | 0.0017 ns | 0.0015 ns |  1.6986 ns |  0.92 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.7319 ns | 0.0023 ns | 0.0022 ns |  1.7327 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.7358 ns | 0.0030 ns | 0.0028 ns |  1.7359 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  2.5829 ns | 0.0069 ns | 0.0061 ns |  2.5828 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  2.7238 ns | 0.0053 ns | 0.0050 ns |  2.7251 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  2.2371 ns | 0.0134 ns | 0.0125 ns |  2.2324 ns |  0.87 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.8224 ns | 0.0220 ns | 0.0206 ns |  2.8153 ns |  1.09 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.8673 ns | 0.0179 ns | 0.0167 ns |  2.8750 ns |  1.11 |    0.01 |     - |     - |     - |         - |
