
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
             FromBool | .NET Core 2.0 |  0.6656 ns | 0.0105 ns | 0.0098 ns |  0.6715 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6724 ns | 0.0044 ns | 0.0039 ns |  0.6713 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9340 ns | 0.0057 ns | 0.0051 ns |  0.9355 ns |  1.40 |    0.02 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9369 ns | 0.0051 ns | 0.0048 ns |  0.9370 ns |  1.41 |    0.02 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9537 ns | 0.0035 ns | 0.0031 ns |  0.9531 ns |  1.43 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1464 ns | 0.0043 ns | 0.0036 ns |  1.1458 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  0.9286 ns | 0.0048 ns | 0.0045 ns |  0.9280 ns |  0.81 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1666 ns | 0.0037 ns | 0.0033 ns |  1.1664 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.2117 ns | 0.0091 ns | 0.0085 ns |  2.2133 ns |  1.93 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.2443 ns | 0.0051 ns | 0.0043 ns |  2.2434 ns |  1.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.6797 ns | 0.0039 ns | 0.0034 ns |  0.6793 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.6412 ns | 0.0039 ns | 0.0036 ns |  0.6416 ns |  0.94 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.7121 ns | 0.0045 ns | 0.0042 ns |  0.7128 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.7194 ns | 0.0051 ns | 0.0048 ns |  0.7196 ns |  1.06 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  0.7416 ns | 0.0094 ns | 0.0088 ns |  0.7444 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.0542 ns | 0.0034 ns | 0.0028 ns |  1.0543 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.0547 ns | 0.0041 ns | 0.0038 ns |  1.0555 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.5383 ns | 0.0051 ns | 0.0046 ns |  1.5384 ns |  1.46 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  2.0221 ns | 0.0036 ns | 0.0033 ns |  2.0215 ns |  1.92 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.0322 ns | 0.0049 ns | 0.0043 ns |  2.0317 ns |  1.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.3064 ns | 0.0030 ns | 0.0026 ns |  1.3064 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.4005 ns | 0.0126 ns | 0.0118 ns |  1.4055 ns |  1.07 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.8844 ns | 0.0025 ns | 0.0021 ns |  0.8843 ns |  0.68 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  2.1879 ns | 0.0029 ns | 0.0026 ns |  2.1872 ns |  1.67 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.7859 ns | 0.0050 ns | 0.0047 ns |  1.7861 ns |  1.37 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.8685 ns | 0.0145 ns | 0.0129 ns |  1.8766 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.8141 ns | 0.0081 ns | 0.0071 ns |  1.8117 ns |  0.97 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.1432 ns | 0.0114 ns | 0.0101 ns |  1.1435 ns |  0.61 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.9354 ns | 0.0059 ns | 0.0052 ns |  2.9345 ns |  1.57 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.9428 ns | 0.0059 ns | 0.0055 ns |  2.9422 ns |  1.57 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.6578 ns | 0.0029 ns | 0.0025 ns |  0.6577 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.5949 ns | 0.0076 ns | 0.0071 ns |  0.5974 ns |  0.90 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.6856 ns | 0.0036 ns | 0.0030 ns |  0.6843 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.7215 ns | 0.0032 ns | 0.0030 ns |  0.7220 ns |  1.10 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.7212 ns | 0.0040 ns | 0.0035 ns |  0.7203 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.0092 ns | 0.0085 ns | 0.0079 ns |  1.0062 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.0301 ns | 0.0036 ns | 0.0034 ns |  1.0308 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.1894 ns | 0.0141 ns | 0.0131 ns |  1.1842 ns |  1.18 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  2.0631 ns | 0.0190 ns | 0.0178 ns |  2.0695 ns |  2.04 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  2.0388 ns | 0.0132 ns | 0.0123 ns |  2.0339 ns |  2.02 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.3114 ns | 0.0064 ns | 0.0057 ns |  1.3107 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.3832 ns | 0.0100 ns | 0.0094 ns |  1.3792 ns |  1.06 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.7006 ns | 0.0025 ns | 0.0023 ns |  0.7007 ns |  0.53 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.8848 ns | 0.0073 ns | 0.0065 ns |  1.8828 ns |  1.44 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  1.9074 ns | 0.0102 ns | 0.0090 ns |  1.9053 ns |  1.45 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  2.0440 ns | 0.0042 ns | 0.0039 ns |  2.0438 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.7892 ns | 0.0058 ns | 0.0051 ns |  1.7887 ns |  0.88 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1261 ns | 0.0042 ns | 0.0040 ns |  1.1251 ns |  0.55 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.8103 ns | 0.0084 ns | 0.0074 ns |  2.8108 ns |  1.37 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.8115 ns | 0.0085 ns | 0.0075 ns |  2.8103 ns |  1.38 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.6878 ns | 0.0057 ns | 0.0053 ns |  0.6888 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.6396 ns | 0.0044 ns | 0.0039 ns |  0.6398 ns |  0.93 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6808 ns | 0.0075 ns | 0.0070 ns |  0.6818 ns |  0.99 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.7088 ns | 0.0028 ns | 0.0025 ns |  0.7087 ns |  1.03 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.7387 ns | 0.0040 ns | 0.0037 ns |  0.7388 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  0.6708 ns | 0.0067 ns | 0.0063 ns |  0.6720 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  0.5460 ns | 0.0039 ns | 0.0035 ns |  0.5459 ns |  0.81 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  0.6505 ns | 0.0049 ns | 0.0041 ns |  0.6500 ns |  0.97 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  0.7235 ns | 0.0018 ns | 0.0015 ns |  0.7235 ns |  1.08 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  0.7511 ns | 0.0037 ns | 0.0032 ns |  0.7516 ns |  1.12 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.7948 ns | 0.0048 ns | 0.0043 ns |  1.7950 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.8527 ns | 0.0026 ns | 0.0023 ns |  1.8529 ns |  1.03 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.8502 ns | 0.0164 ns | 0.0154 ns |  1.8445 ns |  1.03 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  1.9432 ns | 0.0170 ns | 0.0159 ns |  1.9498 ns |  1.08 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  1.9451 ns | 0.0106 ns | 0.0099 ns |  1.9483 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  3.3697 ns | 0.0174 ns | 0.0154 ns |  3.3678 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  2.8281 ns | 0.0201 ns | 0.0188 ns |  2.8352 ns |  0.84 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  2.2564 ns | 0.0046 ns | 0.0043 ns |  2.2570 ns |  0.67 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.8681 ns | 0.0055 ns | 0.0049 ns |  2.8682 ns |  0.85 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.9023 ns | 0.0131 ns | 0.0116 ns |  2.8981 ns |  0.86 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.4687 ns | 0.0051 ns | 0.0045 ns |  1.4698 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.7415 ns | 0.0051 ns | 0.0047 ns |  1.7427 ns |  1.19 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.9109 ns | 0.0032 ns | 0.0030 ns |  0.9108 ns |  0.62 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.9114 ns | 0.0066 ns | 0.0058 ns |  1.9088 ns |  1.30 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.8574 ns | 0.0068 ns | 0.0060 ns |  1.8560 ns |  1.26 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  2.0785 ns | 0.0033 ns | 0.0030 ns |  2.0787 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.9643 ns | 0.0084 ns | 0.0079 ns |  1.9653 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.0984 ns | 0.0061 ns | 0.0054 ns |  1.0979 ns |  0.53 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.8078 ns | 0.0071 ns | 0.0059 ns |  2.8052 ns |  1.35 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  3.1574 ns | 0.0116 ns | 0.0109 ns |  3.1532 ns |  1.52 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.8547 ns | 0.0167 ns | 0.0156 ns |  1.8649 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.8381 ns | 0.0035 ns | 0.0031 ns |  1.8391 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.7007 ns | 0.0042 ns | 0.0040 ns |  1.7015 ns |  0.92 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  1.8949 ns | 0.0046 ns | 0.0040 ns |  1.8935 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.8445 ns | 0.0039 ns | 0.0035 ns |  1.8448 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  3.1753 ns | 0.0118 ns | 0.0099 ns |  3.1730 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  3.2378 ns | 0.0295 ns | 0.0276 ns |  3.2496 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  3.1790 ns | 0.0100 ns | 0.0093 ns |  3.1813 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  3.4156 ns | 0.0096 ns | 0.0089 ns |  3.4141 ns |  1.08 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  3.7032 ns | 0.0107 ns | 0.0095 ns |  3.7000 ns |  1.17 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.8136 ns | 0.0045 ns | 0.0038 ns |  1.8138 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.8045 ns | 0.0061 ns | 0.0054 ns |  1.8048 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.8409 ns | 0.0025 ns | 0.0020 ns |  1.8407 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  2.1878 ns | 0.0698 ns | 0.0717 ns |  2.1924 ns |  1.21 |    0.04 |     - |     - |     - |         - |
            FromULong |        net472 |  1.7912 ns | 0.0179 ns | 0.0167 ns |  1.7984 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  3.0063 ns | 0.0070 ns | 0.0065 ns |  3.0083 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  3.0019 ns | 0.0071 ns | 0.0066 ns |  3.0011 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  3.1302 ns | 0.0140 ns | 0.0124 ns |  3.1262 ns |  1.04 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  3.0588 ns | 0.0083 ns | 0.0078 ns |  3.0568 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  3.3152 ns | 0.0077 ns | 0.0068 ns |  3.3145 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.8437 ns | 0.0332 ns | 0.0310 ns |  3.8227 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  4.1222 ns | 0.0096 ns | 0.0085 ns |  4.1226 ns |  1.07 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  3.9964 ns | 0.0157 ns | 0.0147 ns |  3.9925 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.8517 ns | 0.0056 ns | 0.0052 ns |  3.8509 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.8419 ns | 0.0063 ns | 0.0059 ns |  3.8435 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  4.9562 ns | 0.0376 ns | 0.0352 ns |  4.9701 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  4.8318 ns | 0.0332 ns | 0.0311 ns |  4.8484 ns |  0.97 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  4.2782 ns | 0.0076 ns | 0.0059 ns |  4.2784 ns |  0.86 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  5.2904 ns | 0.0155 ns | 0.0145 ns |  5.2902 ns |  1.07 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.7248 ns | 0.0221 ns | 0.0207 ns |  4.7212 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.7897 ns | 0.0188 ns | 0.0176 ns |  3.7814 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.6160 ns | 0.0093 ns | 0.0082 ns |  3.6164 ns |  0.95 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  4.3036 ns | 0.0221 ns | 0.0207 ns |  4.3122 ns |  1.14 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.7114 ns | 0.0089 ns | 0.0083 ns |  3.7091 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.7883 ns | 0.0068 ns | 0.0064 ns |  3.7890 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  4.6806 ns | 0.0061 ns | 0.0051 ns |  4.6820 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  4.9483 ns | 0.0165 ns | 0.0154 ns |  4.9472 ns |  1.06 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  5.2202 ns | 0.0550 ns | 0.0515 ns |  5.1965 ns |  1.12 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  5.7344 ns | 0.0383 ns | 0.0358 ns |  5.7518 ns |  1.22 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  5.7815 ns | 0.0297 ns | 0.0278 ns |  5.7910 ns |  1.24 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 14.0168 ns | 0.0316 ns | 0.0296 ns | 14.0218 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 14.0350 ns | 0.0302 ns | 0.0283 ns | 14.0333 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  6.9965 ns | 0.1258 ns | 0.1177 ns |  6.9028 ns |  0.50 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 | 14.2289 ns | 0.0297 ns | 0.0263 ns | 14.2207 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 14.1213 ns | 0.0354 ns | 0.0332 ns | 14.1177 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 24.9252 ns | 0.0724 ns | 0.0677 ns | 24.9008 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 24.9433 ns | 0.0686 ns | 0.0642 ns | 24.9394 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 14.2315 ns | 0.1497 ns | 0.1400 ns | 14.2475 ns |  0.57 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 25.9935 ns | 0.0341 ns | 0.0319 ns | 25.9914 ns |  1.04 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 25.0816 ns | 0.0332 ns | 0.0310 ns | 25.0758 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6893 ns | 0.0068 ns | 0.0064 ns |  0.6909 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.9363 ns | 0.0070 ns | 0.0062 ns |  0.9367 ns |  1.36 |    0.02 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7317 ns | 0.0039 ns | 0.0033 ns |  0.7308 ns |  1.06 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7395 ns | 0.0032 ns | 0.0030 ns |  0.7399 ns |  1.07 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.6905 ns | 0.0040 ns | 0.0036 ns |  0.6900 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.5593 ns | 0.0066 ns | 0.0059 ns |  1.5578 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6846 ns | 0.0050 ns | 0.0044 ns |  1.6834 ns |  1.08 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4921 ns | 0.0042 ns | 0.0037 ns |  1.4926 ns |  0.96 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6744 ns | 0.0140 ns | 0.0124 ns |  1.6769 ns |  1.07 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.7584 ns | 0.0164 ns | 0.0154 ns |  1.7647 ns |  1.13 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  9.9594 ns | 0.0121 ns | 0.0114 ns |  9.9582 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 14.2787 ns | 0.0207 ns | 0.0183 ns | 14.2767 ns |  1.43 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 15.1220 ns | 0.0788 ns | 0.0737 ns | 15.1376 ns |  1.52 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 | 13.3327 ns | 0.0283 ns | 0.0251 ns | 13.3295 ns |  1.34 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 13.2156 ns | 0.0230 ns | 0.0192 ns | 13.2121 ns |  1.33 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 48.4149 ns | 0.0605 ns | 0.0536 ns | 48.4171 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 41.9476 ns | 0.1143 ns | 0.1014 ns | 41.9388 ns |  0.87 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  9.5534 ns | 0.0376 ns | 0.0352 ns |  9.5619 ns |  0.20 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 48.1297 ns | 0.4977 ns | 0.4655 ns | 48.2887 ns |  0.99 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 | 47.4137 ns | 0.0728 ns | 0.0681 ns | 47.4263 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.7933 ns | 0.0049 ns | 0.0046 ns |  1.7927 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  2.1967 ns | 0.0036 ns | 0.0034 ns |  2.1960 ns |  1.22 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.6870 ns | 0.0048 ns | 0.0042 ns |  1.6866 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.8975 ns | 0.0042 ns | 0.0037 ns |  1.8974 ns |  1.06 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.8577 ns | 0.0093 ns | 0.0078 ns |  1.8560 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  2.6363 ns | 0.0077 ns | 0.0072 ns |  2.6361 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  2.6464 ns | 0.0069 ns | 0.0061 ns |  2.6466 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  2.2587 ns | 0.0029 ns | 0.0024 ns |  2.2584 ns |  0.86 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.9152 ns | 0.0095 ns | 0.0085 ns |  2.9148 ns |  1.11 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.8567 ns | 0.0059 ns | 0.0055 ns |  2.8561 ns |  1.08 |    0.00 |     - |     - |     - |         - |
