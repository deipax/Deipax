
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
             FromBool | .NET Core 2.0 |  0.9394 ns | 0.0036 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6731 ns | 0.0048 ns | 0.0040 ns |  0.72 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.7074 ns | 0.0123 ns | 0.0115 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6683 ns | 0.0065 ns | 0.0057 ns |  0.71 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9611 ns | 0.0038 ns | 0.0034 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.4048 ns | 0.0049 ns | 0.0045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  0.9624 ns | 0.0064 ns | 0.0060 ns |  0.69 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.0002 ns | 0.0052 ns | 0.0048 ns |  0.71 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.1046 ns | 0.0043 ns | 0.0041 ns |  1.50 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.2563 ns | 0.0052 ns | 0.0046 ns |  1.61 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  1.3406 ns | 0.0175 ns | 0.0163 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  1.4013 ns | 0.0134 ns | 0.0126 ns |  1.05 |    0.02 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.6610 ns | 0.0045 ns | 0.0037 ns |  0.49 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  1.7798 ns | 0.0034 ns | 0.0030 ns |  1.33 |    0.02 |     - |     - |     - |         - |
             FromChar |        net472 |  1.9457 ns | 0.0048 ns | 0.0045 ns |  1.45 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  2.0068 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.7935 ns | 0.0055 ns | 0.0048 ns |  0.89 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1313 ns | 0.0108 ns | 0.0096 ns |  0.56 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  3.2633 ns | 0.0133 ns | 0.0118 ns |  1.63 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.8759 ns | 0.0168 ns | 0.0157 ns |  1.43 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.6980 ns | 0.0055 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.7043 ns | 0.0108 ns | 0.0101 ns |  1.01 |    0.02 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6028 ns | 0.0026 ns | 0.0023 ns |  0.86 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.5744 ns | 0.0047 ns | 0.0039 ns |  0.82 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.7369 ns | 0.0076 ns | 0.0071 ns |  1.06 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.1714 ns | 0.0049 ns | 0.0041 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.9442 ns | 0.0023 ns | 0.0022 ns |  0.81 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9581 ns | 0.0054 ns | 0.0051 ns |  0.82 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.0223 ns | 0.0144 ns | 0.0135 ns |  1.73 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.0617 ns | 0.0057 ns | 0.0051 ns |  1.76 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.9308 ns | 0.0029 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.5664 ns | 0.0041 ns | 0.0032 ns |  0.61 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.7009 ns | 0.0031 ns | 0.0029 ns |  0.75 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  0.5692 ns | 0.0027 ns | 0.0024 ns |  0.61 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.7264 ns | 0.0040 ns | 0.0035 ns |  0.78 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.0155 ns | 0.0027 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9531 ns | 0.0044 ns | 0.0039 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9573 ns | 0.0112 ns | 0.0094 ns |  0.94 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  2.0205 ns | 0.0023 ns | 0.0019 ns |  1.99 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  2.2699 ns | 0.0033 ns | 0.0028 ns |  2.24 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.7086 ns | 0.0126 ns | 0.0118 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.6644 ns | 0.0177 ns | 0.0165 ns |  0.94 |    0.03 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.5927 ns | 0.0039 ns | 0.0032 ns |  0.84 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 |  0.6450 ns | 0.0087 ns | 0.0077 ns |  0.91 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  0.7314 ns | 0.0029 ns | 0.0027 ns |  1.03 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  0.7025 ns | 0.0025 ns | 0.0022 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  0.6117 ns | 0.0038 ns | 0.0036 ns |  0.87 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  0.7353 ns | 0.0038 ns | 0.0030 ns |  1.05 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  0.6033 ns | 0.0082 ns | 0.0073 ns |  0.86 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  0.7380 ns | 0.0147 ns | 0.0137 ns |  1.05 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  1.3426 ns | 0.0027 ns | 0.0021 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  1.4013 ns | 0.0194 ns | 0.0181 ns |  1.04 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6327 ns | 0.0067 ns | 0.0059 ns |  0.47 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |  1.7767 ns | 0.0053 ns | 0.0044 ns |  1.32 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 |  1.9457 ns | 0.0068 ns | 0.0064 ns |  1.45 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  2.1022 ns | 0.0061 ns | 0.0057 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.7977 ns | 0.0037 ns | 0.0031 ns |  0.86 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1589 ns | 0.0210 ns | 0.0197 ns |  0.55 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.8852 ns | 0.0187 ns | 0.0175 ns |  1.37 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.8778 ns | 0.0084 ns | 0.0075 ns |  1.37 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  2.1615 ns | 0.0040 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.8264 ns | 0.0036 ns | 0.0030 ns |  0.84 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  2.1161 ns | 0.0117 ns | 0.0104 ns |  0.98 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7747 ns | 0.0036 ns | 0.0034 ns |  0.82 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  1.8251 ns | 0.0119 ns | 0.0111 ns |  0.84 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.9619 ns | 0.0182 ns | 0.0161 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  2.7266 ns | 0.0097 ns | 0.0086 ns |  0.92 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  2.2676 ns | 0.0068 ns | 0.0063 ns |  0.77 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.8754 ns | 0.0073 ns | 0.0057 ns |  0.97 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.9053 ns | 0.0184 ns | 0.0172 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.8658 ns | 0.0066 ns | 0.0062 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.8384 ns | 0.0113 ns | 0.0094 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  1.7253 ns | 0.0152 ns | 0.0135 ns |  0.92 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.7526 ns | 0.0043 ns | 0.0040 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.7386 ns | 0.0034 ns | 0.0027 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  2.6058 ns | 0.0065 ns | 0.0051 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  2.5579 ns | 0.0056 ns | 0.0052 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  2.3949 ns | 0.0078 ns | 0.0069 ns |  0.92 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.7938 ns | 0.0053 ns | 0.0050 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.7883 ns | 0.0054 ns | 0.0050 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.8954 ns | 0.0181 ns | 0.0170 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  2.1374 ns | 0.0160 ns | 0.0150 ns |  1.13 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.7363 ns | 0.0131 ns | 0.0116 ns |  0.92 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  1.7922 ns | 0.0066 ns | 0.0062 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  2.4660 ns | 0.0074 ns | 0.0062 ns |  1.30 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  2.9262 ns | 0.0261 ns | 0.0244 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  3.1238 ns | 0.0061 ns | 0.0057 ns |  1.07 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  3.0883 ns | 0.0132 ns | 0.0123 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  3.2077 ns | 0.0149 ns | 0.0140 ns |  1.10 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  3.2024 ns | 0.0035 ns | 0.0031 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.9065 ns | 0.0056 ns | 0.0053 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.7411 ns | 0.0038 ns | 0.0030 ns |  0.91 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  2.1739 ns | 0.0181 ns | 0.0161 ns |  1.14 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  1.8109 ns | 0.0065 ns | 0.0054 ns |  0.95 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.8015 ns | 0.0075 ns | 0.0070 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  3.0640 ns | 0.0082 ns | 0.0076 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  3.1733 ns | 0.0244 ns | 0.0229 ns |  1.04 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  2.6368 ns | 0.0078 ns | 0.0073 ns |  0.86 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  3.0995 ns | 0.0048 ns | 0.0037 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  3.1111 ns | 0.0184 ns | 0.0172 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.9804 ns | 0.0095 ns | 0.0075 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.9361 ns | 0.0045 ns | 0.0040 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  4.1578 ns | 0.0443 ns | 0.0415 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  4.1113 ns | 0.0063 ns | 0.0056 ns |  1.03 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  4.0813 ns | 0.0053 ns | 0.0047 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  5.2843 ns | 0.0338 ns | 0.0316 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  4.7652 ns | 0.0107 ns | 0.0100 ns |  0.90 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  4.3475 ns | 0.0146 ns | 0.0137 ns |  0.82 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  4.7878 ns | 0.0264 ns | 0.0247 ns |  0.91 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.7378 ns | 0.0076 ns | 0.0063 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.9619 ns | 0.0101 ns | 0.0084 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  4.0745 ns | 0.0057 ns | 0.0053 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  4.0235 ns | 0.0066 ns | 0.0058 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.4647 ns | 0.0076 ns | 0.0071 ns |  0.87 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.4785 ns | 0.0165 ns | 0.0154 ns |  0.88 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  4.8735 ns | 0.0336 ns | 0.0314 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  4.9204 ns | 0.0217 ns | 0.0203 ns |  1.01 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  4.9781 ns | 0.0365 ns | 0.0342 ns |  1.02 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  5.7697 ns | 0.0163 ns | 0.0136 ns |  1.18 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  5.8009 ns | 0.0275 ns | 0.0244 ns |  1.19 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 14.2172 ns | 0.0321 ns | 0.0268 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 14.2218 ns | 0.0216 ns | 0.0202 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  6.9820 ns | 0.1404 ns | 0.1313 ns |  0.49 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 | 14.5698 ns | 0.0672 ns | 0.0628 ns |  1.02 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net472 | 14.5575 ns | 0.0676 ns | 0.0633 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 25.9787 ns | 0.0342 ns | 0.0267 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 25.2332 ns | 0.0362 ns | 0.0338 ns |  0.97 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 14.2334 ns | 0.1085 ns | 0.1015 ns |  0.55 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 25.6024 ns | 0.0656 ns | 0.0581 ns |  0.99 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 25.4925 ns | 0.0513 ns | 0.0480 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  1.1093 ns | 0.0042 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.9413 ns | 0.0041 ns | 0.0032 ns |  0.85 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7292 ns | 0.0035 ns | 0.0029 ns |  0.66 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7017 ns | 0.0039 ns | 0.0036 ns |  0.63 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.9221 ns | 0.0054 ns | 0.0051 ns |  0.83 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.6144 ns | 0.0058 ns | 0.0051 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6921 ns | 0.0046 ns | 0.0041 ns |  1.05 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4852 ns | 0.0113 ns | 0.0106 ns |  0.92 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.7028 ns | 0.0026 ns | 0.0022 ns |  1.05 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6732 ns | 0.0067 ns | 0.0059 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 10.2749 ns | 0.0518 ns | 0.0459 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 14.5039 ns | 0.0739 ns | 0.0691 ns |  1.41 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 15.1831 ns | 0.0296 ns | 0.0262 ns |  1.48 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 | 13.3720 ns | 0.0209 ns | 0.0186 ns |  1.30 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 | 13.7548 ns | 0.0275 ns | 0.0258 ns |  1.34 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 48.8318 ns | 0.0584 ns | 0.0546 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 43.4372 ns | 0.0644 ns | 0.0602 ns |  0.89 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  9.8902 ns | 0.0096 ns | 0.0080 ns |  0.20 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 47.5349 ns | 0.2350 ns | 0.2198 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 47.0214 ns | 0.0375 ns | 0.0333 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.9150 ns | 0.0207 ns | 0.0193 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.8528 ns | 0.0173 ns | 0.0161 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.7252 ns | 0.0026 ns | 0.0023 ns |  0.90 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.7843 ns | 0.0132 ns | 0.0117 ns |  0.93 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.7812 ns | 0.0166 ns | 0.0156 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  2.6646 ns | 0.0062 ns | 0.0058 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  2.7153 ns | 0.0102 ns | 0.0091 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  2.2673 ns | 0.0038 ns | 0.0033 ns |  0.85 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  3.0536 ns | 0.0186 ns | 0.0174 ns |  1.15 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.9166 ns | 0.0258 ns | 0.0241 ns |  1.09 |    0.01 |     - |     - |     - |         - |
