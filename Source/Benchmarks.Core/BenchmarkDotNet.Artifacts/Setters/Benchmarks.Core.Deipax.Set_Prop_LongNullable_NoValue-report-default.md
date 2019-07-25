
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
             FromBool | .NET Core 2.0 |  0.9222 ns | 0.0037 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6803 ns | 0.0046 ns | 0.0038 ns |  0.74 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9077 ns | 0.0058 ns | 0.0055 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  1.0010 ns | 0.0036 ns | 0.0034 ns |  1.09 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.7243 ns | 0.0043 ns | 0.0040 ns |  0.79 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.0115 ns | 0.0026 ns | 0.0024 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.3326 ns | 0.0076 ns | 0.0067 ns |  1.32 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9464 ns | 0.0125 ns | 0.0111 ns |  0.94 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.9474 ns | 0.0049 ns | 0.0041 ns |  1.93 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.9110 ns | 0.0024 ns | 0.0020 ns |  1.89 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9317 ns | 0.0033 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.6839 ns | 0.0035 ns | 0.0033 ns |  0.73 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.8851 ns | 0.0026 ns | 0.0023 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  0.7377 ns | 0.0030 ns | 0.0026 ns |  0.79 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.6329 ns | 0.0034 ns | 0.0032 ns |  0.68 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.1663 ns | 0.0041 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.0583 ns | 0.0037 ns | 0.0031 ns |  0.91 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.0728 ns | 0.0175 ns | 0.0164 ns |  0.92 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.9297 ns | 0.0061 ns | 0.0051 ns |  1.66 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.9261 ns | 0.0086 ns | 0.0072 ns |  1.65 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.6934 ns | 0.0028 ns | 0.0024 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.5735 ns | 0.0030 ns | 0.0028 ns |  0.83 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  1.1088 ns | 0.0467 ns | 0.0414 ns |  1.60 |    0.06 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.7183 ns | 0.0032 ns | 0.0030 ns |  1.04 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.5552 ns | 0.0028 ns | 0.0026 ns |  0.80 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.1874 ns | 0.0029 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.9253 ns | 0.0013 ns | 0.0010 ns |  0.78 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.1525 ns | 0.0032 ns | 0.0025 ns |  0.97 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.9794 ns | 0.0023 ns | 0.0020 ns |  1.67 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.9380 ns | 0.0197 ns | 0.0184 ns |  1.63 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.9183 ns | 0.0026 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.5918 ns | 0.0081 ns | 0.0067 ns |  0.64 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.7086 ns | 0.0031 ns | 0.0028 ns |  0.77 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  0.7162 ns | 0.0026 ns | 0.0024 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.5553 ns | 0.0029 ns | 0.0025 ns |  0.60 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.1674 ns | 0.0065 ns | 0.0061 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9384 ns | 0.0033 ns | 0.0027 ns |  0.80 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.1468 ns | 0.0038 ns | 0.0032 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9679 ns | 0.0165 ns | 0.0154 ns |  1.69 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9086 ns | 0.0052 ns | 0.0046 ns |  1.63 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.6926 ns | 0.0027 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.6628 ns | 0.0190 ns | 0.0178 ns |  0.96 |    0.02 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.7091 ns | 0.0107 ns | 0.0100 ns |  1.02 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 |  0.7187 ns | 0.0025 ns | 0.0021 ns |  1.04 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  0.6302 ns | 0.0034 ns | 0.0030 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.1527 ns | 0.0039 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.1005 ns | 0.0041 ns | 0.0038 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1592 ns | 0.0051 ns | 0.0045 ns |  1.01 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.9262 ns | 0.0033 ns | 0.0031 ns |  1.67 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.8933 ns | 0.0040 ns | 0.0036 ns |  1.64 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.9272 ns | 0.0047 ns | 0.0044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.6872 ns | 0.0025 ns | 0.0021 ns |  0.74 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.7000 ns | 0.0140 ns | 0.0131 ns |  0.76 |    0.02 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.7407 ns | 0.0044 ns | 0.0041 ns |  0.80 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.6315 ns | 0.0039 ns | 0.0032 ns |  0.68 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.1671 ns | 0.0033 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.1376 ns | 0.0026 ns | 0.0024 ns |  0.97 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1691 ns | 0.0037 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.9291 ns | 0.0063 ns | 0.0056 ns |  1.65 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.9261 ns | 0.0130 ns | 0.0102 ns |  1.65 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.6873 ns | 0.0034 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.5805 ns | 0.0044 ns | 0.0039 ns |  0.84 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.7162 ns | 0.0045 ns | 0.0040 ns |  1.04 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  0.7160 ns | 0.0037 ns | 0.0032 ns |  1.04 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  0.5631 ns | 0.0056 ns | 0.0050 ns |  0.82 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.1583 ns | 0.0155 ns | 0.0145 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.0711 ns | 0.0143 ns | 0.0134 ns |  0.92 |    0.02 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.0794 ns | 0.0077 ns | 0.0072 ns |  0.93 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.9510 ns | 0.0136 ns | 0.0120 ns |  1.68 |    0.02 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.8979 ns | 0.0043 ns | 0.0038 ns |  1.64 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.9207 ns | 0.0029 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.5715 ns | 0.0105 ns | 0.0088 ns |  0.62 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.6472 ns | 0.0030 ns | 0.0028 ns |  0.70 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.6644 ns | 0.0034 ns | 0.0028 ns |  0.72 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.5703 ns | 0.0037 ns | 0.0033 ns |  0.62 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.0099 ns | 0.0058 ns | 0.0054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.0794 ns | 0.0062 ns | 0.0058 ns |  1.07 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.0638 ns | 0.0132 ns | 0.0124 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.9120 ns | 0.0164 ns | 0.0154 ns |  1.89 |    0.02 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.8946 ns | 0.0031 ns | 0.0028 ns |  1.88 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  0.6918 ns | 0.0035 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  0.6521 ns | 0.0060 ns | 0.0056 ns |  0.94 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.7031 ns | 0.0027 ns | 0.0024 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  0.6845 ns | 0.0024 ns | 0.0021 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  0.6493 ns | 0.0040 ns | 0.0037 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.1511 ns | 0.0044 ns | 0.0041 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.1586 ns | 0.0045 ns | 0.0042 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.2197 ns | 0.0034 ns | 0.0032 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  1.1226 ns | 0.0035 ns | 0.0032 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  1.1692 ns | 0.0021 ns | 0.0019 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.4210 ns | 0.0051 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.4585 ns | 0.0045 ns | 0.0038 ns |  1.03 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.8938 ns | 0.0023 ns | 0.0021 ns |  0.63 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.7546 ns | 0.0034 ns | 0.0032 ns |  1.24 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.7191 ns | 0.0028 ns | 0.0026 ns |  1.21 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.9752 ns | 0.0171 ns | 0.0160 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.9049 ns | 0.0055 ns | 0.0043 ns |  0.96 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.5264 ns | 0.0042 ns | 0.0035 ns |  0.77 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  1.9365 ns | 0.0053 ns | 0.0050 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  1.8966 ns | 0.0052 ns | 0.0046 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.2196 ns | 0.0075 ns | 0.0063 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  2.1592 ns | 0.0044 ns | 0.0041 ns |  0.67 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  2.0048 ns | 0.0183 ns | 0.0162 ns |  0.62 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.6767 ns | 0.0086 ns | 0.0072 ns |  1.14 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.5201 ns | 0.0248 ns | 0.0207 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.9440 ns | 0.0035 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.7549 ns | 0.0053 ns | 0.0044 ns |  0.90 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.6799 ns | 0.0036 ns | 0.0032 ns |  0.86 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.9001 ns | 0.0057 ns | 0.0048 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.9026 ns | 0.0047 ns | 0.0044 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  2.9732 ns | 0.0077 ns | 0.0069 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  1.9359 ns | 0.0065 ns | 0.0057 ns |  0.65 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  1.9070 ns | 0.0057 ns | 0.0054 ns |  0.64 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.6808 ns | 0.0150 ns | 0.0133 ns |  1.24 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.4441 ns | 0.0083 ns | 0.0069 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.9284 ns | 0.0343 ns | 0.0320 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.9301 ns | 0.0078 ns | 0.0069 ns |  1.00 |    0.02 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.9365 ns | 0.0043 ns | 0.0036 ns |  1.00 |    0.02 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.1291 ns | 0.0113 ns | 0.0106 ns |  1.10 |    0.02 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.1094 ns | 0.0047 ns | 0.0042 ns |  1.09 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.5124 ns | 0.0198 ns | 0.0185 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.5182 ns | 0.0357 ns | 0.0298 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.9554 ns | 0.1249 ns | 0.1168 ns |  0.44 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.5969 ns | 0.0171 ns | 0.0151 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.6264 ns | 0.0354 ns | 0.0331 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  9.5539 ns | 0.1380 ns | 0.1291 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  8.7751 ns | 0.0163 ns | 0.0152 ns |  0.92 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  2.6193 ns | 0.0154 ns | 0.0129 ns |  0.27 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  9.2016 ns | 0.0186 ns | 0.0165 ns |  0.96 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  9.1723 ns | 0.0119 ns | 0.0105 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9321 ns | 0.0028 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.6832 ns | 0.0077 ns | 0.0064 ns |  0.73 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  1.3978 ns | 0.0086 ns | 0.0081 ns |  1.50 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.8928 ns | 0.0031 ns | 0.0026 ns |  0.96 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.6935 ns | 0.0210 ns | 0.0196 ns |  0.74 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4576 ns | 0.0030 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6635 ns | 0.0046 ns | 0.0041 ns |  1.14 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4795 ns | 0.0034 ns | 0.0028 ns |  1.02 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6380 ns | 0.0054 ns | 0.0045 ns |  1.12 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6620 ns | 0.0052 ns | 0.0049 ns |  1.14 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  3.1038 ns | 0.0219 ns | 0.0204 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.8518 ns | 0.0101 ns | 0.0094 ns |  0.92 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.6702 ns | 0.0161 ns | 0.0134 ns |  0.86 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  2.8876 ns | 0.0281 ns | 0.0262 ns |  0.93 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  2.8919 ns | 0.0070 ns | 0.0062 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  1.8296 ns | 0.0031 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  2.1241 ns | 0.0042 ns | 0.0040 ns |  1.16 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.8768 ns | 0.0044 ns | 0.0041 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 |  1.7909 ns | 0.0045 ns | 0.0040 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 |  1.7865 ns | 0.0019 ns | 0.0018 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.9205 ns | 0.0031 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.6640 ns | 0.0028 ns | 0.0026 ns |  0.72 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.7001 ns | 0.0032 ns | 0.0027 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.6698 ns | 0.0029 ns | 0.0027 ns |  0.73 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.5654 ns | 0.0025 ns | 0.0023 ns |  0.61 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.0114 ns | 0.0036 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.0871 ns | 0.0045 ns | 0.0035 ns |  1.08 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.0643 ns | 0.0066 ns | 0.0059 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.9314 ns | 0.0040 ns | 0.0038 ns |  1.91 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.2792 ns | 0.0046 ns | 0.0043 ns |  2.25 |    0.01 |     - |     - |     - |         - |
