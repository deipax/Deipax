
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
             FromBool | .NET Core 2.0 |  0.9272 ns | 0.0061 ns | 0.0057 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  1.1822 ns | 0.0037 ns | 0.0035 ns |  1.28 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  1.1243 ns | 0.0038 ns | 0.0034 ns |  1.21 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  1.1690 ns | 0.0059 ns | 0.0056 ns |  1.26 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  1.1862 ns | 0.0017 ns | 0.0016 ns |  1.28 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.3861 ns | 0.0034 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.4144 ns | 0.0063 ns | 0.0059 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1488 ns | 0.0026 ns | 0.0023 ns |  0.83 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.8575 ns | 0.0040 ns | 0.0036 ns |  1.34 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.6560 ns | 0.0034 ns | 0.0030 ns |  1.19 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  1.1541 ns | 0.0031 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  1.1165 ns | 0.0108 ns | 0.0101 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.6944 ns | 0.0057 ns | 0.0053 ns |  0.60 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  1.8585 ns | 0.0030 ns | 0.0026 ns |  1.61 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  1.9105 ns | 0.0103 ns | 0.0096 ns |  1.66 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.6293 ns | 0.0037 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.6175 ns | 0.0035 ns | 0.0031 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1538 ns | 0.0035 ns | 0.0033 ns |  0.71 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  2.3316 ns | 0.0027 ns | 0.0024 ns |  1.43 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.3274 ns | 0.0045 ns | 0.0040 ns |  1.43 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.6960 ns | 0.0064 ns | 0.0060 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.7074 ns | 0.0032 ns | 0.0025 ns |  1.02 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6972 ns | 0.0106 ns | 0.0099 ns |  1.00 |    0.02 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.7218 ns | 0.0022 ns | 0.0021 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.7191 ns | 0.0043 ns | 0.0040 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  0.9398 ns | 0.0027 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.9415 ns | 0.0024 ns | 0.0023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.8825 ns | 0.0037 ns | 0.0034 ns |  0.94 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.4118 ns | 0.0035 ns | 0.0029 ns |  1.50 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.5076 ns | 0.0017 ns | 0.0013 ns |  1.60 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  1.1558 ns | 0.0024 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  1.1781 ns | 0.0038 ns | 0.0034 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.6885 ns | 0.0025 ns | 0.0023 ns |  0.60 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  1.6521 ns | 0.0058 ns | 0.0055 ns |  1.43 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  1.6495 ns | 0.0048 ns | 0.0040 ns |  1.43 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.4730 ns | 0.0032 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.4688 ns | 0.0161 ns | 0.0151 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.1607 ns | 0.0036 ns | 0.0031 ns |  0.79 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  2.1445 ns | 0.0047 ns | 0.0042 ns |  1.46 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  2.1693 ns | 0.0056 ns | 0.0050 ns |  1.47 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.6778 ns | 0.0042 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.9698 ns | 0.0037 ns | 0.0034 ns |  1.17 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  1.9112 ns | 0.0042 ns | 0.0039 ns |  1.14 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.8565 ns | 0.0038 ns | 0.0033 ns |  1.11 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  1.8773 ns | 0.0039 ns | 0.0036 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  2.3123 ns | 0.0039 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  2.1085 ns | 0.0044 ns | 0.0041 ns |  0.91 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  2.2977 ns | 0.0182 ns | 0.0170 ns |  0.99 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.3112 ns | 0.0042 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.3490 ns | 0.0058 ns | 0.0051 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  1.1546 ns | 0.0026 ns | 0.0022 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  1.2302 ns | 0.0062 ns | 0.0058 ns |  1.07 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.9228 ns | 0.0029 ns | 0.0027 ns |  0.80 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |  1.6483 ns | 0.0082 ns | 0.0068 ns |  1.43 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  1.6663 ns | 0.0039 ns | 0.0036 ns |  1.44 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.6293 ns | 0.0048 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.6187 ns | 0.0040 ns | 0.0036 ns |  0.99 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1088 ns | 0.0025 ns | 0.0023 ns |  0.68 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.1409 ns | 0.0026 ns | 0.0023 ns |  1.31 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.1742 ns | 0.0042 ns | 0.0032 ns |  1.33 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.6050 ns | 0.0023 ns | 0.0022 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.7051 ns | 0.0124 ns | 0.0116 ns |  1.06 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.6666 ns | 0.0034 ns | 0.0029 ns |  1.04 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  1.6532 ns | 0.0027 ns | 0.0024 ns |  1.03 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  1.6858 ns | 0.0030 ns | 0.0028 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.2704 ns | 0.0059 ns | 0.0055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  2.4617 ns | 0.0069 ns | 0.0061 ns |  1.08 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  2.2719 ns | 0.0062 ns | 0.0058 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.4023 ns | 0.0183 ns | 0.0162 ns |  1.06 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.1759 ns | 0.0032 ns | 0.0027 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.2284 ns | 0.0021 ns | 0.0019 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.6401 ns | 0.0103 ns | 0.0097 ns |  1.34 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.6773 ns | 0.0101 ns | 0.0095 ns |  0.55 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.8628 ns | 0.0025 ns | 0.0022 ns |  1.52 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.8252 ns | 0.0035 ns | 0.0033 ns |  1.49 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.7739 ns | 0.0045 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.6193 ns | 0.0039 ns | 0.0033 ns |  0.91 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  0.9280 ns | 0.0027 ns | 0.0024 ns |  0.52 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.5690 ns | 0.0084 ns | 0.0078 ns |  1.45 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.5149 ns | 0.0049 ns | 0.0041 ns |  1.42 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.8336 ns | 0.0116 ns | 0.0109 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.6393 ns | 0.0031 ns | 0.0027 ns |  0.89 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.8374 ns | 0.0195 ns | 0.0182 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  1.6552 ns | 0.0036 ns | 0.0033 ns |  0.90 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.6327 ns | 0.0051 ns | 0.0048 ns |  0.89 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  3.2999 ns | 0.0074 ns | 0.0065 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  2.6241 ns | 0.0076 ns | 0.0064 ns |  0.80 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  2.9317 ns | 0.0095 ns | 0.0089 ns |  0.89 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.8524 ns | 0.0046 ns | 0.0043 ns |  0.86 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.8749 ns | 0.0065 ns | 0.0057 ns |  0.87 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.2262 ns | 0.0030 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.1773 ns | 0.0095 ns | 0.0084 ns |  0.96 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.5376 ns | 0.0106 ns | 0.0099 ns |  0.44 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  1.6504 ns | 0.0032 ns | 0.0030 ns |  1.35 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.6094 ns | 0.0035 ns | 0.0031 ns |  1.31 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.9628 ns | 0.0041 ns | 0.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.8176 ns | 0.0043 ns | 0.0041 ns |  0.93 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.7314 ns | 0.0032 ns | 0.0030 ns |  0.88 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  3.0032 ns | 0.0228 ns | 0.0213 ns |  1.53 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.9698 ns | 0.0068 ns | 0.0057 ns |  1.51 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.6541 ns | 0.0081 ns | 0.0076 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.9584 ns | 0.0289 ns | 0.0271 ns |  1.08 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  3.9339 ns | 0.0076 ns | 0.0067 ns |  1.08 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.9091 ns | 0.0060 ns | 0.0053 ns |  1.07 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.9374 ns | 0.0031 ns | 0.0026 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  4.3893 ns | 0.0046 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  4.0753 ns | 0.0082 ns | 0.0077 ns |  0.93 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  4.3371 ns | 0.0268 ns | 0.0251 ns |  0.99 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  4.2399 ns | 0.0072 ns | 0.0064 ns |  0.97 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.1656 ns | 0.0076 ns | 0.0067 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.7474 ns | 0.0171 ns | 0.0160 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.8442 ns | 0.0047 ns | 0.0042 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  4.6928 ns | 0.1206 ns | 0.1185 ns |  1.25 |    0.03 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.2596 ns | 0.0092 ns | 0.0082 ns |  0.87 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.2381 ns | 0.0093 ns | 0.0082 ns |  0.86 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  5.3763 ns | 0.1091 ns | 0.1020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  4.9739 ns | 0.0237 ns | 0.0210 ns |  0.92 |    0.02 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  5.2824 ns | 0.0119 ns | 0.0093 ns |  0.98 |    0.02 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  4.7091 ns | 0.0132 ns | 0.0124 ns |  0.88 |    0.02 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  4.8126 ns | 0.0075 ns | 0.0070 ns |  0.90 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.5242 ns | 0.0174 ns | 0.0154 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.7232 ns | 0.0174 ns | 0.0163 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  6.6464 ns | 0.0080 ns | 0.0075 ns |  0.49 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.9615 ns | 0.0204 ns | 0.0191 ns |  1.03 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.9894 ns | 0.0292 ns | 0.0259 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 24.2085 ns | 0.0263 ns | 0.0234 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 24.7497 ns | 0.0566 ns | 0.0529 ns |  1.02 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 13.0295 ns | 0.0322 ns | 0.0302 ns |  0.54 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 24.4700 ns | 0.0234 ns | 0.0208 ns |  1.01 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 24.7708 ns | 0.0413 ns | 0.0386 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6912 ns | 0.0031 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.6819 ns | 0.0054 ns | 0.0048 ns |  0.99 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.8634 ns | 0.0078 ns | 0.0069 ns |  1.25 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7467 ns | 0.0020 ns | 0.0017 ns |  1.08 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.6703 ns | 0.0059 ns | 0.0055 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.3874 ns | 0.0028 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6566 ns | 0.0166 ns | 0.0138 ns |  1.19 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.3850 ns | 0.0037 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.4143 ns | 0.0064 ns | 0.0060 ns |  1.02 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6700 ns | 0.0030 ns | 0.0025 ns |  1.20 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.3198 ns | 0.0068 ns | 0.0063 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.2389 ns | 0.0104 ns | 0.0093 ns |  0.96 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.1094 ns | 0.0148 ns | 0.0139 ns |  0.91 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  2.3793 ns | 0.0164 ns | 0.0153 ns |  1.03 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  2.2257 ns | 0.0046 ns | 0.0041 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 47.6578 ns | 0.3034 ns | 0.2838 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 42.9846 ns | 0.2292 ns | 0.2144 ns |  0.90 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  8.1940 ns | 0.0156 ns | 0.0139 ns |  0.17 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 46.4984 ns | 0.0569 ns | 0.0504 ns |  0.98 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 | 46.3013 ns | 0.0684 ns | 0.0639 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.6074 ns | 0.0033 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.6581 ns | 0.0034 ns | 0.0032 ns |  1.03 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.8274 ns | 0.0029 ns | 0.0025 ns |  1.14 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.8566 ns | 0.0045 ns | 0.0042 ns |  1.16 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.8065 ns | 0.0024 ns | 0.0020 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  2.0251 ns | 0.0034 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  2.4392 ns | 0.0116 ns | 0.0103 ns |  1.20 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  2.1861 ns | 0.0037 ns | 0.0033 ns |  1.08 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.3106 ns | 0.0067 ns | 0.0056 ns |  1.14 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.2838 ns | 0.0060 ns | 0.0053 ns |  1.13 |    0.00 |     - |     - |     - |         - |
