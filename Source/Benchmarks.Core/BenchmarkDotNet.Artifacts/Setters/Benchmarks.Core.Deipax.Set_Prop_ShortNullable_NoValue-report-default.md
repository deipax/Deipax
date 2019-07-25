
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
             FromBool | .NET Core 2.0 |  0.9450 ns | 0.0137 ns | 0.0128 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9497 ns | 0.0030 ns | 0.0025 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9315 ns | 0.0030 ns | 0.0027 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6705 ns | 0.0031 ns | 0.0028 ns |  0.71 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9639 ns | 0.0074 ns | 0.0069 ns |  1.02 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1754 ns | 0.0034 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1927 ns | 0.0045 ns | 0.0042 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1545 ns | 0.0042 ns | 0.0039 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.9503 ns | 0.0046 ns | 0.0043 ns |  1.66 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.9859 ns | 0.0184 ns | 0.0172 ns |  1.69 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  1.3416 ns | 0.0045 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  1.7063 ns | 0.0089 ns | 0.0079 ns |  1.27 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.6874 ns | 0.0037 ns | 0.0035 ns |  0.51 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  1.7802 ns | 0.0077 ns | 0.0072 ns |  1.33 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  1.9658 ns | 0.0123 ns | 0.0115 ns |  1.47 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.8667 ns | 0.0033 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.7868 ns | 0.0052 ns | 0.0046 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1834 ns | 0.0044 ns | 0.0039 ns |  0.63 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.9193 ns | 0.0050 ns | 0.0047 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.9435 ns | 0.0035 ns | 0.0031 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.7030 ns | 0.0062 ns | 0.0055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.9761 ns | 0.0036 ns | 0.0033 ns |  1.39 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6735 ns | 0.0039 ns | 0.0034 ns |  0.96 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.5677 ns | 0.0043 ns | 0.0036 ns |  0.81 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.7335 ns | 0.0034 ns | 0.0030 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.1774 ns | 0.0031 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.2146 ns | 0.0031 ns | 0.0029 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.1518 ns | 0.0050 ns | 0.0045 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.9499 ns | 0.0040 ns | 0.0033 ns |  1.66 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.9734 ns | 0.0053 ns | 0.0044 ns |  1.68 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.9310 ns | 0.0054 ns | 0.0045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7286 ns | 0.0033 ns | 0.0029 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.7395 ns | 0.0046 ns | 0.0039 ns |  0.79 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.5686 ns | 0.0043 ns | 0.0036 ns |  0.61 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.7361 ns | 0.0123 ns | 0.0115 ns |  0.79 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.1748 ns | 0.0029 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.2159 ns | 0.0084 ns | 0.0079 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9773 ns | 0.0082 ns | 0.0077 ns |  0.83 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9450 ns | 0.0042 ns | 0.0035 ns |  1.66 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  2.1600 ns | 0.0160 ns | 0.0150 ns |  1.84 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.7012 ns | 0.0023 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.7167 ns | 0.0064 ns | 0.0054 ns |  1.02 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.7875 ns | 0.0333 ns | 0.0311 ns |  1.12 |    0.05 |     - |     - |     - |         - |
            FromShort |        net461 |  0.6450 ns | 0.0068 ns | 0.0064 ns |  0.92 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  0.7209 ns | 0.0035 ns | 0.0031 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  0.7064 ns | 0.0069 ns | 0.0061 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  0.7255 ns | 0.0031 ns | 0.0029 ns |  1.03 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  0.9358 ns | 0.0033 ns | 0.0028 ns |  1.32 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  0.6019 ns | 0.0039 ns | 0.0033 ns |  0.85 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  0.7186 ns | 0.0037 ns | 0.0031 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  1.3446 ns | 0.0043 ns | 0.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  1.4164 ns | 0.0115 ns | 0.0102 ns |  1.05 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.7188 ns | 0.0106 ns | 0.0094 ns |  0.53 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  1.8034 ns | 0.0119 ns | 0.0100 ns |  1.34 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  2.1930 ns | 0.0087 ns | 0.0077 ns |  1.63 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.8772 ns | 0.0041 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.8151 ns | 0.0076 ns | 0.0067 ns |  0.97 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.5616 ns | 0.0143 ns | 0.0133 ns |  0.83 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.9219 ns | 0.0058 ns | 0.0049 ns |  1.02 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.9696 ns | 0.0147 ns | 0.0137 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.8852 ns | 0.0079 ns | 0.0074 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.9220 ns | 0.0045 ns | 0.0035 ns |  1.02 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  2.0832 ns | 0.0096 ns | 0.0090 ns |  1.11 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7807 ns | 0.0060 ns | 0.0057 ns |  0.94 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  1.8112 ns | 0.0149 ns | 0.0139 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.8839 ns | 0.0117 ns | 0.0109 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.7787 ns | 0.0045 ns | 0.0040 ns |  0.94 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.7505 ns | 0.0155 ns | 0.0145 ns |  0.93 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.9164 ns | 0.0114 ns | 0.0106 ns |  1.02 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.9616 ns | 0.0084 ns | 0.0078 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.8622 ns | 0.0037 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.8348 ns | 0.0081 ns | 0.0072 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  1.8759 ns | 0.0030 ns | 0.0025 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.7493 ns | 0.0046 ns | 0.0041 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  2.4547 ns | 0.0041 ns | 0.0036 ns |  1.32 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.8730 ns | 0.0045 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.7848 ns | 0.0070 ns | 0.0062 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.7158 ns | 0.0074 ns | 0.0070 ns |  0.92 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.9280 ns | 0.0036 ns | 0.0034 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.9166 ns | 0.0035 ns | 0.0029 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.8767 ns | 0.0030 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  2.1606 ns | 0.0028 ns | 0.0024 ns |  1.15 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.7073 ns | 0.0132 ns | 0.0123 ns |  0.91 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  1.7789 ns | 0.0038 ns | 0.0034 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  1.8801 ns | 0.0048 ns | 0.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.7871 ns | 0.0134 ns | 0.0125 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.8616 ns | 0.0021 ns | 0.0016 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.8248 ns | 0.0053 ns | 0.0047 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.0326 ns | 0.0043 ns | 0.0036 ns |  1.14 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  1.9382 ns | 0.0063 ns | 0.0059 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  2.2408 ns | 0.0179 ns | 0.0167 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.7604 ns | 0.0046 ns | 0.0039 ns |  0.79 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.8548 ns | 0.0059 ns | 0.0050 ns |  0.83 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  1.8057 ns | 0.0028 ns | 0.0024 ns |  0.81 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 |  1.8230 ns | 0.0122 ns | 0.0108 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.8622 ns | 0.0042 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.8439 ns | 0.0128 ns | 0.0120 ns |  0.99 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.8237 ns | 0.0046 ns | 0.0043 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  1.9492 ns | 0.0107 ns | 0.0100 ns |  1.05 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  1.9757 ns | 0.0098 ns | 0.0087 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.9785 ns | 0.0116 ns | 0.0103 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  4.3797 ns | 0.0277 ns | 0.0259 ns |  1.10 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  4.1451 ns | 0.0094 ns | 0.0079 ns |  1.04 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  4.0170 ns | 0.0087 ns | 0.0081 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  4.0508 ns | 0.0097 ns | 0.0086 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.9346 ns | 0.0193 ns | 0.0180 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.9460 ns | 0.0061 ns | 0.0055 ns |  1.01 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.7272 ns | 0.0075 ns | 0.0063 ns |  0.89 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.9682 ns | 0.0064 ns | 0.0060 ns |  1.02 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.9324 ns | 0.0055 ns | 0.0051 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.9780 ns | 0.0064 ns | 0.0060 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.9521 ns | 0.0122 ns | 0.0114 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  4.2130 ns | 0.0060 ns | 0.0056 ns |  1.06 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.4701 ns | 0.0057 ns | 0.0050 ns |  0.87 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.4585 ns | 0.0113 ns | 0.0094 ns |  0.87 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.9384 ns | 0.0160 ns | 0.0150 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.9172 ns | 0.0028 ns | 0.0026 ns |  0.99 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.9695 ns | 0.0032 ns | 0.0025 ns |  1.02 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.1520 ns | 0.0073 ns | 0.0065 ns |  1.11 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.1554 ns | 0.0113 ns | 0.0106 ns |  1.11 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 14.0528 ns | 0.0232 ns | 0.0205 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 14.1722 ns | 0.0219 ns | 0.0194 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  7.0756 ns | 0.0938 ns | 0.0878 ns |  0.50 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 | 14.4449 ns | 0.0343 ns | 0.0321 ns |  1.03 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 14.4517 ns | 0.0684 ns | 0.0640 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.3197 ns | 0.0211 ns | 0.0187 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  8.7361 ns | 0.0488 ns | 0.0457 ns |  1.05 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  2.5957 ns | 0.0212 ns | 0.0198 ns |  0.31 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  9.3223 ns | 0.0195 ns | 0.0173 ns |  1.12 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  9.2960 ns | 0.0167 ns | 0.0156 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9403 ns | 0.0095 ns | 0.0089 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.9831 ns | 0.0025 ns | 0.0022 ns |  1.05 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7406 ns | 0.0057 ns | 0.0053 ns |  0.79 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7100 ns | 0.0026 ns | 0.0024 ns |  0.76 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.8884 ns | 0.0048 ns | 0.0045 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4781 ns | 0.0038 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6832 ns | 0.0116 ns | 0.0108 ns |  1.14 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.5061 ns | 0.0084 ns | 0.0074 ns |  1.02 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.7026 ns | 0.0043 ns | 0.0040 ns |  1.15 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6630 ns | 0.0056 ns | 0.0050 ns |  1.13 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  3.0917 ns | 0.0061 ns | 0.0057 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  3.3880 ns | 0.0095 ns | 0.0089 ns |  1.10 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.7661 ns | 0.0070 ns | 0.0065 ns |  0.89 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  2.8860 ns | 0.0093 ns | 0.0082 ns |  0.93 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  3.0550 ns | 0.0099 ns | 0.0093 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  1.8737 ns | 0.0111 ns | 0.0104 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  1.9323 ns | 0.0071 ns | 0.0055 ns |  1.03 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.9618 ns | 0.0169 ns | 0.0158 ns |  1.05 |    0.01 |     - |     - |     - |         - |
           FromString |        net461 |  1.8243 ns | 0.0036 ns | 0.0032 ns |  0.97 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 |  1.8167 ns | 0.0071 ns | 0.0059 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.9088 ns | 0.0044 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.9471 ns | 0.0038 ns | 0.0032 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.7134 ns | 0.0108 ns | 0.0101 ns |  0.90 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.7818 ns | 0.0045 ns | 0.0035 ns |  0.93 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.7715 ns | 0.0054 ns | 0.0051 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.8706 ns | 0.0038 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.7831 ns | 0.0077 ns | 0.0072 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.7214 ns | 0.0036 ns | 0.0032 ns |  0.92 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.9245 ns | 0.0040 ns | 0.0038 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.9097 ns | 0.0039 ns | 0.0036 ns |  1.02 |    0.00 |     - |     - |     - |         - |
