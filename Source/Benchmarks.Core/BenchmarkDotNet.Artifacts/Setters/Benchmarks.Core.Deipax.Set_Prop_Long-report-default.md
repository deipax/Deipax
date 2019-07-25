
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-JBIYRV : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-GQVRNQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-BKGSYN : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-NLOXWC : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-AAMQWS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  0.9474 ns | 0.0081 ns | 0.0076 ns |  0.9504 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  1.1754 ns | 0.0044 ns | 0.0041 ns |  1.1762 ns |  1.24 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9234 ns | 0.0030 ns | 0.0026 ns |  0.9225 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9087 ns | 0.0030 ns | 0.0028 ns |  0.9083 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  1.1766 ns | 0.0044 ns | 0.0041 ns |  1.1764 ns |  1.24 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.3953 ns | 0.0052 ns | 0.0046 ns |  1.3957 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.4089 ns | 0.0047 ns | 0.0041 ns |  1.4087 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1984 ns | 0.0033 ns | 0.0031 ns |  1.1974 ns |  0.86 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.6411 ns | 0.0035 ns | 0.0031 ns |  1.6416 ns |  1.18 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.6588 ns | 0.0043 ns | 0.0034 ns |  1.6581 ns |  1.19 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.7162 ns | 0.0259 ns | 0.0242 ns |  0.7042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.7108 ns | 0.0029 ns | 0.0027 ns |  0.7116 ns |  0.99 |    0.03 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.4892 ns | 0.0020 ns | 0.0016 ns |  0.4893 ns |  0.69 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.4494 ns | 0.0057 ns | 0.0054 ns |  0.4496 ns |  0.63 |    0.02 |     - |     - |     - |         - |
             FromChar |        net472 |  0.7423 ns | 0.0017 ns | 0.0014 ns |  0.7424 ns |  1.05 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.1808 ns | 0.0271 ns | 0.0240 ns |  1.1721 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.1939 ns | 0.0047 ns | 0.0044 ns |  1.1929 ns |  1.01 |    0.02 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.9568 ns | 0.0080 ns | 0.0075 ns |  0.9541 ns |  0.81 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.6239 ns | 0.0139 ns | 0.0130 ns |  1.6283 ns |  1.37 |    0.03 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.6386 ns | 0.0034 ns | 0.0030 ns |  1.6376 ns |  1.39 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.6788 ns | 0.0132 ns | 0.0103 ns |  0.6822 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.7314 ns | 0.0018 ns | 0.0016 ns |  0.7316 ns |  1.08 |    0.02 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.4968 ns | 0.0043 ns | 0.0040 ns |  0.4959 ns |  0.73 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.4415 ns | 0.0026 ns | 0.0023 ns |  0.4421 ns |  0.65 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.7187 ns | 0.0066 ns | 0.0062 ns |  0.7193 ns |  1.06 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  0.9314 ns | 0.0095 ns | 0.0089 ns |  0.9295 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.1948 ns | 0.0051 ns | 0.0047 ns |  1.1941 ns |  1.28 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9559 ns | 0.0034 ns | 0.0032 ns |  0.9555 ns |  1.03 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.6647 ns | 0.0094 ns | 0.0083 ns |  1.6606 ns |  1.79 |    0.02 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.6734 ns | 0.0020 ns | 0.0019 ns |  1.6738 ns |  1.80 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.7028 ns | 0.0113 ns | 0.0106 ns |  0.6984 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7303 ns | 0.0016 ns | 0.0015 ns |  0.7296 ns |  1.04 |    0.02 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.4912 ns | 0.0018 ns | 0.0017 ns |  0.4914 ns |  0.70 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.4516 ns | 0.0042 ns | 0.0037 ns |  0.4516 ns |  0.64 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.7138 ns | 0.0105 ns | 0.0098 ns |  0.7098 ns |  1.02 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.1664 ns | 0.0087 ns | 0.0081 ns |  1.1678 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.1762 ns | 0.0034 ns | 0.0031 ns |  1.1765 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9622 ns | 0.0140 ns | 0.0131 ns |  0.9557 ns |  0.82 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.6481 ns | 0.0041 ns | 0.0037 ns |  1.6475 ns |  1.41 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.6665 ns | 0.0025 ns | 0.0024 ns |  1.6663 ns |  1.43 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.6927 ns | 0.0033 ns | 0.0029 ns |  0.6920 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.7087 ns | 0.0020 ns | 0.0018 ns |  0.7087 ns |  1.02 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.4667 ns | 0.0028 ns | 0.0026 ns |  0.4670 ns |  0.67 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 |  0.4495 ns | 0.0029 ns | 0.0027 ns |  0.4499 ns |  0.65 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  0.7151 ns | 0.0023 ns | 0.0020 ns |  0.7151 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  0.9223 ns | 0.0057 ns | 0.0053 ns |  0.9207 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.1781 ns | 0.0144 ns | 0.0135 ns |  1.1711 ns |  1.28 |    0.02 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  0.9539 ns | 0.0039 ns | 0.0033 ns |  0.9546 ns |  1.03 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.6221 ns | 0.0154 ns | 0.0144 ns |  1.6254 ns |  1.76 |    0.02 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.6538 ns | 0.0040 ns | 0.0038 ns |  1.6521 ns |  1.79 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.6978 ns | 0.0053 ns | 0.0047 ns |  0.6974 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.7111 ns | 0.0036 ns | 0.0030 ns |  0.7115 ns |  1.02 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.4665 ns | 0.0069 ns | 0.0065 ns |  0.4706 ns |  0.67 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.4469 ns | 0.0020 ns | 0.0016 ns |  0.4472 ns |  0.64 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.7408 ns | 0.0030 ns | 0.0026 ns |  0.7410 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.1631 ns | 0.0179 ns | 0.0167 ns |  1.1552 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.1922 ns | 0.0044 ns | 0.0039 ns |  1.1924 ns |  1.02 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  0.9529 ns | 0.0021 ns | 0.0017 ns |  0.9520 ns |  0.82 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.6245 ns | 0.0040 ns | 0.0035 ns |  1.6244 ns |  1.40 |    0.02 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.6724 ns | 0.0046 ns | 0.0041 ns |  1.6714 ns |  1.44 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.6987 ns | 0.0046 ns | 0.0041 ns |  0.6997 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.7296 ns | 0.0033 ns | 0.0031 ns |  0.7299 ns |  1.04 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.4997 ns | 0.0064 ns | 0.0060 ns |  0.5029 ns |  0.72 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  0.4464 ns | 0.0027 ns | 0.0022 ns |  0.4457 ns |  0.64 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  0.7167 ns | 0.0030 ns | 0.0026 ns |  0.7165 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  0.9224 ns | 0.0039 ns | 0.0034 ns |  0.9230 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.1942 ns | 0.0034 ns | 0.0028 ns |  1.1942 ns |  1.29 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  0.9492 ns | 0.0032 ns | 0.0030 ns |  0.9493 ns |  1.03 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.6203 ns | 0.0048 ns | 0.0045 ns |  1.6208 ns |  1.76 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.6344 ns | 0.0051 ns | 0.0045 ns |  1.6344 ns |  1.77 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.6985 ns | 0.0073 ns | 0.0068 ns |  0.6972 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.7216 ns | 0.0038 ns | 0.0030 ns |  0.7234 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.6902 ns | 0.0045 ns | 0.0040 ns |  0.6898 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.7406 ns | 0.0162 ns | 0.0151 ns |  0.7318 ns |  1.06 |    0.03 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.6666 ns | 0.0028 ns | 0.0027 ns |  0.6665 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.1617 ns | 0.0037 ns | 0.0031 ns |  1.1611 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.1812 ns | 0.0040 ns | 0.0035 ns |  1.1821 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  0.9594 ns | 0.0041 ns | 0.0037 ns |  0.9592 ns |  0.83 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.6641 ns | 0.0048 ns | 0.0043 ns |  1.6648 ns |  1.43 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.6576 ns | 0.0117 ns | 0.0109 ns |  1.6600 ns |  1.43 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  0.6929 ns | 0.0019 ns | 0.0018 ns |  0.6923 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  0.8279 ns | 0.0037 ns | 0.0033 ns |  0.8286 ns |  1.19 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.8394 ns | 0.0035 ns | 0.0031 ns |  0.8389 ns |  1.21 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  0.7108 ns | 0.0029 ns | 0.0027 ns |  0.7111 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  0.6637 ns | 0.0041 ns | 0.0034 ns |  0.6623 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.4798 ns | 0.0102 ns | 0.0096 ns |  1.4815 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.4695 ns | 0.0028 ns | 0.0025 ns |  1.4702 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.9718 ns | 0.0662 ns | 0.1790 ns |  2.0470 ns |  1.33 |    0.13 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  1.8817 ns | 0.0165 ns | 0.0155 ns |  1.8899 ns |  1.27 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  1.9305 ns | 0.0108 ns | 0.0101 ns |  1.9289 ns |  1.30 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.2625 ns | 0.0042 ns | 0.0035 ns |  1.2631 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.2267 ns | 0.0030 ns | 0.0027 ns |  1.2269 ns |  0.97 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.6951 ns | 0.0043 ns | 0.0039 ns |  0.6943 ns |  0.55 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.6410 ns | 0.0040 ns | 0.0035 ns |  1.6419 ns |  1.30 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.6122 ns | 0.0029 ns | 0.0027 ns |  1.6125 ns |  1.28 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.9761 ns | 0.0067 ns | 0.0062 ns |  1.9781 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.9732 ns | 0.0049 ns | 0.0043 ns |  1.9721 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.7065 ns | 0.0047 ns | 0.0042 ns |  1.7067 ns |  0.86 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.7158 ns | 0.0098 ns | 0.0087 ns |  2.7132 ns |  1.37 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.5993 ns | 0.0070 ns | 0.0065 ns |  2.5987 ns |  1.32 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.1535 ns | 0.0077 ns | 0.0072 ns |  3.1560 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  2.1144 ns | 0.0040 ns | 0.0037 ns |  2.1136 ns |  0.67 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  1.9462 ns | 0.0069 ns | 0.0061 ns |  1.9450 ns |  0.62 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.5129 ns | 0.0066 ns | 0.0059 ns |  3.5137 ns |  1.11 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.4655 ns | 0.0218 ns | 0.0204 ns |  3.4575 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  3.7322 ns | 0.0214 ns | 0.0200 ns |  3.7383 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  2.3736 ns | 0.0067 ns | 0.0062 ns |  2.3722 ns |  0.64 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  2.5811 ns | 0.0177 ns | 0.0165 ns |  2.5878 ns |  0.69 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  4.2006 ns | 0.0100 ns | 0.0088 ns |  4.1983 ns |  1.13 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  3.9997 ns | 0.0093 ns | 0.0082 ns |  4.0010 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.0559 ns | 0.0053 ns | 0.0050 ns |  3.0569 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  1.8910 ns | 0.0105 ns | 0.0098 ns |  1.8920 ns |  0.62 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  1.8819 ns | 0.0038 ns | 0.0034 ns |  1.8808 ns |  0.62 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.5893 ns | 0.0055 ns | 0.0049 ns |  3.5899 ns |  1.17 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.7537 ns | 0.0032 ns | 0.0028 ns |  3.7531 ns |  1.23 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  4.3711 ns | 0.0204 ns | 0.0191 ns |  4.3654 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  3.1495 ns | 0.0081 ns | 0.0068 ns |  3.1483 ns |  0.72 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  3.0350 ns | 0.0081 ns | 0.0067 ns |  3.0356 ns |  0.69 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  4.4969 ns | 0.0090 ns | 0.0080 ns |  4.4988 ns |  1.03 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  4.4958 ns | 0.0431 ns | 0.0403 ns |  4.4756 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 12.9564 ns | 0.0120 ns | 0.0100 ns | 12.9523 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.1820 ns | 0.0155 ns | 0.0137 ns | 13.1812 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.6334 ns | 0.0131 ns | 0.0109 ns |  5.6315 ns |  0.43 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.6019 ns | 0.0730 ns | 0.0683 ns | 13.6198 ns |  1.05 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.3975 ns | 0.0257 ns | 0.0228 ns | 13.3955 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 23.8891 ns | 0.1162 ns | 0.1087 ns | 23.8374 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 23.7924 ns | 0.0290 ns | 0.0257 ns | 23.7974 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 12.7831 ns | 0.0411 ns | 0.0364 ns | 12.7722 ns |  0.54 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 23.9949 ns | 0.0355 ns | 0.0315 ns | 23.9935 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 23.9728 ns | 0.0498 ns | 0.0441 ns | 23.9665 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6980 ns | 0.0050 ns | 0.0047 ns |  0.6989 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7477 ns | 0.0087 ns | 0.0082 ns |  0.7505 ns |  1.07 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.6981 ns | 0.0026 ns | 0.0024 ns |  0.6987 ns |  1.00 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7341 ns | 0.0036 ns | 0.0032 ns |  0.7346 ns |  1.05 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.6514 ns | 0.0025 ns | 0.0020 ns |  0.6519 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4057 ns | 0.0041 ns | 0.0034 ns |  1.4059 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.4109 ns | 0.0055 ns | 0.0049 ns |  1.4099 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.3671 ns | 0.0041 ns | 0.0036 ns |  1.3670 ns |  0.97 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.4258 ns | 0.0025 ns | 0.0022 ns |  1.4252 ns |  1.01 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.4152 ns | 0.0109 ns | 0.0102 ns |  1.4115 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.2663 ns | 0.0057 ns | 0.0053 ns |  2.2661 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.2578 ns | 0.0040 ns | 0.0037 ns |  2.2575 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.1565 ns | 0.0172 ns | 0.0152 ns |  2.1607 ns |  0.95 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  2.7063 ns | 0.0055 ns | 0.0049 ns |  2.7056 ns |  1.19 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  2.2370 ns | 0.0153 ns | 0.0143 ns |  2.2325 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 48.9614 ns | 0.0868 ns | 0.0770 ns | 48.9669 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 40.3209 ns | 0.0784 ns | 0.0734 ns | 40.2995 ns |  0.82 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 10.6328 ns | 0.0232 ns | 0.0217 ns | 10.6401 ns |  0.22 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 47.8709 ns | 0.2632 ns | 0.2334 ns | 47.9407 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 47.1633 ns | 0.0687 ns | 0.0609 ns | 47.1703 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.6963 ns | 0.0028 ns | 0.0025 ns |  0.6960 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.7249 ns | 0.0038 ns | 0.0033 ns |  0.7244 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.5011 ns | 0.0109 ns | 0.0102 ns |  0.4976 ns |  0.72 |    0.02 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.7296 ns | 0.0034 ns | 0.0032 ns |  0.7292 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.6653 ns | 0.0032 ns | 0.0026 ns |  0.6654 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.1608 ns | 0.0095 ns | 0.0089 ns |  1.1635 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.5742 ns | 0.0138 ns | 0.0129 ns |  1.5808 ns |  1.36 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.1584 ns | 0.0032 ns | 0.0027 ns |  1.1583 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.6419 ns | 0.0030 ns | 0.0028 ns |  1.6417 ns |  1.41 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.6056 ns | 0.0029 ns | 0.0027 ns |  1.6059 ns |  1.38 |    0.01 |     - |     - |     - |         - |
