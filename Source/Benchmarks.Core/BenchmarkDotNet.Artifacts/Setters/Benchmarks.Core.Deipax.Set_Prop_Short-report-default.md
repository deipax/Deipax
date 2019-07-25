
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-JBIYRV : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-GQVRNQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-BKGSYN : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-NLOXWC : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-AAMQWS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  0.7370 ns | 0.0046 ns | 0.0041 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  1.1767 ns | 0.0035 ns | 0.0029 ns |  1.60 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9754 ns | 0.0118 ns | 0.0110 ns |  1.32 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  1.1897 ns | 0.0120 ns | 0.0112 ns |  1.61 |    0.02 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9231 ns | 0.0107 ns | 0.0100 ns |  1.25 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1874 ns | 0.0036 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.4377 ns | 0.0128 ns | 0.0114 ns |  1.21 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9717 ns | 0.0038 ns | 0.0035 ns |  0.82 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.7122 ns | 0.0073 ns | 0.0068 ns |  1.44 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.6686 ns | 0.0188 ns | 0.0175 ns |  1.41 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  1.1420 ns | 0.0049 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  1.6567 ns | 0.0128 ns | 0.0119 ns |  1.45 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.5123 ns | 0.0025 ns | 0.0022 ns |  0.45 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  1.8947 ns | 0.0059 ns | 0.0055 ns |  1.66 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  1.6269 ns | 0.0041 ns | 0.0039 ns |  1.42 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.7928 ns | 0.0048 ns | 0.0045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.6540 ns | 0.0189 ns | 0.0177 ns |  0.92 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1769 ns | 0.0063 ns | 0.0052 ns |  0.66 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  2.3804 ns | 0.0053 ns | 0.0044 ns |  1.33 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.1553 ns | 0.0086 ns | 0.0072 ns |  1.20 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.4823 ns | 0.0147 ns | 0.0137 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.7344 ns | 0.0044 ns | 0.0041 ns |  1.52 |    0.04 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.5049 ns | 0.0045 ns | 0.0042 ns |  1.05 |    0.03 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.7374 ns | 0.0040 ns | 0.0033 ns |  1.53 |    0.04 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.4463 ns | 0.0023 ns | 0.0021 ns |  0.93 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  0.8788 ns | 0.0039 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.9711 ns | 0.0044 ns | 0.0037 ns |  1.10 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.7470 ns | 0.0115 ns | 0.0108 ns |  0.85 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.7283 ns | 0.0092 ns | 0.0086 ns |  1.97 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.6768 ns | 0.0038 ns | 0.0036 ns |  1.91 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.4984 ns | 0.0038 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7360 ns | 0.0036 ns | 0.0033 ns |  1.48 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.5014 ns | 0.0020 ns | 0.0017 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.7387 ns | 0.0047 ns | 0.0044 ns |  1.48 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  1.1216 ns | 0.0050 ns | 0.0047 ns |  2.25 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.9735 ns | 0.0023 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9513 ns | 0.0051 ns | 0.0045 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.7478 ns | 0.0113 ns | 0.0106 ns |  0.77 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.7079 ns | 0.0030 ns | 0.0027 ns |  1.75 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.8737 ns | 0.0126 ns | 0.0117 ns |  1.92 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.5055 ns | 0.0095 ns | 0.0089 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.7132 ns | 0.0039 ns | 0.0030 ns |  1.41 |    0.03 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.7047 ns | 0.0036 ns | 0.0031 ns |  1.39 |    0.03 |     - |     - |     - |         - |
            FromShort |        net461 |  0.7156 ns | 0.0038 ns | 0.0035 ns |  1.42 |    0.03 |     - |     - |     - |         - |
            FromShort |        net472 |  0.4501 ns | 0.0019 ns | 0.0017 ns |  0.89 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.0207 ns | 0.0040 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  0.9557 ns | 0.0047 ns | 0.0044 ns |  0.94 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  0.9582 ns | 0.0032 ns | 0.0030 ns |  0.94 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.4325 ns | 0.0029 ns | 0.0024 ns |  1.40 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.4133 ns | 0.0151 ns | 0.0142 ns |  1.38 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  1.1243 ns | 0.0042 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  1.1835 ns | 0.0068 ns | 0.0053 ns |  1.05 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.5254 ns | 0.0041 ns | 0.0039 ns |  0.47 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |  1.9032 ns | 0.0107 ns | 0.0100 ns |  1.69 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  1.6279 ns | 0.0033 ns | 0.0031 ns |  1.45 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.6389 ns | 0.0050 ns | 0.0045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.6515 ns | 0.0105 ns | 0.0098 ns |  1.01 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1741 ns | 0.0024 ns | 0.0018 ns |  0.72 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.6289 ns | 0.0077 ns | 0.0068 ns |  1.60 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.3379 ns | 0.0319 ns | 0.0298 ns |  1.43 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  2.0712 ns | 0.0030 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.6840 ns | 0.0033 ns | 0.0031 ns |  0.81 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.6973 ns | 0.0031 ns | 0.0029 ns |  0.82 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  2.3764 ns | 0.0151 ns | 0.0141 ns |  1.15 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  1.6915 ns | 0.0123 ns | 0.0115 ns |  0.82 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.2391 ns | 0.0055 ns | 0.0051 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  2.2219 ns | 0.0177 ns | 0.0166 ns |  0.99 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.8004 ns | 0.0045 ns | 0.0040 ns |  0.80 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.3825 ns | 0.0141 ns | 0.0125 ns |  1.06 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.1739 ns | 0.0049 ns | 0.0039 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.5817 ns | 0.0054 ns | 0.0048 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.7336 ns | 0.0060 ns | 0.0053 ns |  1.10 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  1.6897 ns | 0.0044 ns | 0.0037 ns |  1.07 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.6925 ns | 0.0050 ns | 0.0044 ns |  1.07 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.6963 ns | 0.0211 ns | 0.0198 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  2.0656 ns | 0.0176 ns | 0.0156 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  2.5134 ns | 0.0065 ns | 0.0055 ns |  1.22 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  2.8152 ns | 0.0154 ns | 0.0144 ns |  1.36 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.3618 ns | 0.0055 ns | 0.0051 ns |  1.14 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.5750 ns | 0.0046 ns | 0.0039 ns |  1.24 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.6000 ns | 0.0038 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.9340 ns | 0.0114 ns | 0.0107 ns |  1.21 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.7437 ns | 0.0054 ns | 0.0048 ns |  1.09 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.9018 ns | 0.0048 ns | 0.0044 ns |  1.19 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  2.0870 ns | 0.0138 ns | 0.0129 ns |  1.30 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  2.6722 ns | 0.0106 ns | 0.0100 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  3.1409 ns | 0.0098 ns | 0.0092 ns |  1.18 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  3.1382 ns | 0.0094 ns | 0.0088 ns |  1.17 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  3.0556 ns | 0.0063 ns | 0.0059 ns |  1.14 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  3.1157 ns | 0.0086 ns | 0.0072 ns |  1.17 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.6491 ns | 0.0030 ns | 0.0023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.8210 ns | 0.0056 ns | 0.0052 ns |  1.10 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.9636 ns | 0.0037 ns | 0.0035 ns |  1.19 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.6895 ns | 0.0041 ns | 0.0036 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.6701 ns | 0.0138 ns | 0.0129 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.9767 ns | 0.0079 ns | 0.0070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  2.5793 ns | 0.0090 ns | 0.0075 ns |  0.87 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  2.7041 ns | 0.0239 ns | 0.0212 ns |  0.91 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.7934 ns | 0.0083 ns | 0.0074 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.8664 ns | 0.0187 ns | 0.0175 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.8938 ns | 0.0130 ns | 0.0115 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.9516 ns | 0.0366 ns | 0.0342 ns |  1.01 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  3.8735 ns | 0.0101 ns | 0.0095 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.9571 ns | 0.0085 ns | 0.0075 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  4.0661 ns | 0.0090 ns | 0.0070 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  4.5046 ns | 0.0413 ns | 0.0386 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  4.3378 ns | 0.0071 ns | 0.0067 ns |  0.96 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  4.1272 ns | 0.0106 ns | 0.0083 ns |  0.91 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  4.2739 ns | 0.0087 ns | 0.0073 ns |  0.95 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.7268 ns | 0.0112 ns | 0.0099 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  4.1030 ns | 0.0187 ns | 0.0175 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.5499 ns | 0.0091 ns | 0.0076 ns |  0.86 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  3.7932 ns | 0.0093 ns | 0.0082 ns |  0.92 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.3460 ns | 0.0138 ns | 0.0122 ns |  0.82 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.3284 ns | 0.0083 ns | 0.0069 ns |  0.81 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  5.5039 ns | 0.0078 ns | 0.0069 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  4.9785 ns | 0.0070 ns | 0.0066 ns |  0.90 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  5.3477 ns | 0.0190 ns | 0.0159 ns |  0.97 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  4.8402 ns | 0.0051 ns | 0.0045 ns |  0.88 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  4.9020 ns | 0.0176 ns | 0.0165 ns |  0.89 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.7688 ns | 0.0199 ns | 0.0176 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.9711 ns | 0.0222 ns | 0.0207 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  6.9128 ns | 0.1385 ns | 0.1295 ns |  0.50 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 | 14.2157 ns | 0.0179 ns | 0.0158 ns |  1.03 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 14.2579 ns | 0.0197 ns | 0.0175 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 24.5469 ns | 0.0323 ns | 0.0303 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 24.6574 ns | 0.0314 ns | 0.0262 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 13.2205 ns | 0.0204 ns | 0.0191 ns |  0.54 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 24.9654 ns | 0.0475 ns | 0.0444 ns |  1.02 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 25.1939 ns | 0.0827 ns | 0.0773 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.5925 ns | 0.0039 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7596 ns | 0.0036 ns | 0.0033 ns |  1.28 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7073 ns | 0.0080 ns | 0.0075 ns |  1.19 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7577 ns | 0.0162 ns | 0.0152 ns |  1.28 |    0.03 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7174 ns | 0.0027 ns | 0.0024 ns |  1.21 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.5380 ns | 0.0046 ns | 0.0041 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.4536 ns | 0.0174 ns | 0.0163 ns |  0.95 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4417 ns | 0.0041 ns | 0.0036 ns |  0.94 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.4382 ns | 0.0110 ns | 0.0097 ns |  0.94 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.4918 ns | 0.0045 ns | 0.0039 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.2593 ns | 0.0037 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.7082 ns | 0.0800 ns | 0.1402 ns |  1.19 |    0.06 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.1604 ns | 0.0136 ns | 0.0106 ns |  0.96 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  2.2970 ns | 0.0042 ns | 0.0039 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  2.2962 ns | 0.0064 ns | 0.0053 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 48.7355 ns | 0.0838 ns | 0.0784 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 42.7369 ns | 0.1657 ns | 0.1550 ns |  0.88 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  9.2118 ns | 0.0218 ns | 0.0204 ns |  0.19 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 46.8676 ns | 0.0671 ns | 0.0595 ns |  0.96 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 46.8630 ns | 0.1551 ns | 0.1450 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.6896 ns | 0.0184 ns | 0.0172 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.7802 ns | 0.0081 ns | 0.0072 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.7026 ns | 0.0045 ns | 0.0038 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.6967 ns | 0.0060 ns | 0.0050 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.6978 ns | 0.0042 ns | 0.0040 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  2.0452 ns | 0.0051 ns | 0.0045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  2.5207 ns | 0.0042 ns | 0.0035 ns |  1.23 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  2.1320 ns | 0.0118 ns | 0.0104 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.3646 ns | 0.0170 ns | 0.0133 ns |  1.16 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.7180 ns | 0.0098 ns | 0.0087 ns |  1.33 |    0.01 |     - |     - |     - |         - |
